using ContactManager.Models;
using ContactManager.Services;
using ContactManager.ViewModels;
using Microsoft.Extensions.Logging;

namespace ContactManager
{
    public partial class FrmSaveContact : Form
    {
        private int id
        {
            get;
            set;
        }

        private string firstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }

        private string lastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }

        private string phoneNo
        {
            get
            {
                return txtPhoneNo.Text;
            }
            set
            {
                txtPhoneNo.Text = value;
            }
        }

        private string? email
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }

        private string address
        {
            get
            {
                return rtbAddress.Text;
            }
            set
            {
                rtbAddress.Text = value;
            }
        }

        private string? website
        {
            get
            {
                return txtWebsite.Text;
            }
            set
            {
                txtWebsite.Text = value;
            }
        }

        private bool isNewRecord
        {
            get
            {
                return id == 0;
            }
        }

        public bool HasChanged { get; private set; } = default;

        private readonly ILogger<FrmSaveContact> logger;
        private readonly IContactService service;

        private Contact contact = new();

        public FrmSaveContact(
            ILogger<FrmSaveContact> logger,
            IContactService service)
        {
            InitializeComponent();

            this.logger = logger;
            this.service = service;
        }

        public void SetParams(int? id = null)
        {
            this.id = id ?? default;
        }

        private void FrmSaveContact_Load(object sender, EventArgs e)
        {
            logger.LogInformation("FrmSaveContact_Load...");
            TryExecute(() =>
            {
                if (!isNewRecord)
                {
                    // Load details
                    var contact = service.GetOne(this.id);
                    BindDetails(ContactVM.From(contact));
                }
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                if (!ValidateInputs())
                {
                    return;
                }

                SetDetails();
                if (isNewRecord)
                {
                    service.AddOne(contact);
                    logger.LogInformation($"Add new contact: {JsonHelper.Serialize(contact)}");
                }
                else
                {
                    service.UpdateOne(contact);
                    logger.LogInformation($"Update existing contact: {JsonHelper.Serialize(contact)}");
                }

                HasChanged = true;
                MessageBox.Show(
                    "Saved successfully.",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            });
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    SetRequiredFieldErrorMessage(textBox);
                }
                else
                {
                    SetRequiredFieldErrorMessage(textBox, string.Empty);
                }
                return;
            }

            if (sender is RichTextBox)
            {
                var richTextBox = (RichTextBox)sender;
                if (string.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    SetRequiredFieldErrorMessage(richTextBox);
                }
                else
                {
                    SetRequiredFieldErrorMessage(richTextBox, string.Empty);
                }
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindDetails(ContactVM contactVM)
        {
            firstName = contactVM.FirstName;
            lastName = contactVM.LastName;
            phoneNo = contactVM.PhoneNo;
            email = contactVM.Email;
            address = contactVM.Address;
            website = contactVM.Website;
        }

        private void SetDetails()
        {
            contact.Id = id;
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.PhoneNo = phoneNo;
            contact.Email = email;
            contact.Address = address;
            contact.Website = website;
        }

        private bool ValidateInputs()
        {
            int invalidControlCount = default;
            ValidateTextValue(firstName, txtFirstName, ref invalidControlCount);
            ValidateTextValue(lastName, txtLastName, ref invalidControlCount);
            ValidateTextValue(phoneNo, txtPhoneNo, ref invalidControlCount);
            ValidateTextValue(address, rtbAddress, ref invalidControlCount);

            return invalidControlCount == 0;
        }

        private void ValidateTextValue(
            string value,
            Control control,
            ref int invalidControlCount)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                SetRequiredFieldErrorMessage(control);
                invalidControlCount += 1;
            }
            else
            {
                SetRequiredFieldErrorMessage(control, string.Empty);
            }
        }

        private void SetRequiredFieldErrorMessage(
            Control control,
            string message = "This field is required")
        {
            errorMessageProvider.SetError(control, message);
        }

        private void TryExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error has occurred while processing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                logger.LogError(ex.Message);
            }
        }
    }
}
