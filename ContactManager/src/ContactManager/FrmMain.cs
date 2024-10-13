using ContactManager.Services;
using ContactManager.ViewModels;

namespace ContactManager
{
    public partial class FrmMain : Form
    {
        private readonly ContactService service;
        private int selectedId;

        public FrmMain()
        {
            InitializeComponent();
            service = new ContactService();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                dgvContact.AutoGenerateColumns = false;
                ResizeGridColumns();
                BindContacts();

                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            });
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                FrmSaveContact saveContact = new FrmSaveContact();
                saveContact.ShowDialog();
                if (saveContact.HasChanged)
                {
                    BindContacts();
                }
            });
        }

        private void dgvContact_SelectionChanged(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                if (dgvContact.SelectedRows.Count > 0)
                {
                    selectedId = Convert.ToInt32(dgvContact.SelectedRows[0].Cells["colId"].Value);
                    var contact = service.GetOne(selectedId);
                    BindContactDetails(ContactVM.From(contact));

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                FrmSaveContact saveContact = new FrmSaveContact(selectedId);
                saveContact.ShowDialog();
                if (saveContact.HasChanged)
                {
                    BindContacts();
                }
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                var deleteConfirmation = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Delete?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (deleteConfirmation == DialogResult.Yes)
                {
                    service.DeleteOne(selectedId);
                    MessageBox.Show(
                        "Deleted successfully.",
                        "Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    BindContacts();
                }
            });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TryExecute(() => BindContacts());
        }

        private void ResizeGridColumns()
        {
            var totalWidth = dgvContact.ClientSize.Width;

            dgvContact.Columns["colSN"].Width = (int)(totalWidth * 0.05);
            dgvContact.Columns["colFirstName"].Width = (int)(totalWidth * 0.25);
            dgvContact.Columns["colLastName"].Width = (int)(totalWidth * 0.25);
            dgvContact.Columns["colPhoneNo"].Width = (int)(totalWidth * 0.25);
            dgvContact.Columns["colEmail"].Width = (int)(totalWidth * 0.20);
        }

        private void BindContacts()
        {
            var contacts = string.IsNullOrWhiteSpace(txtSearch.Text)
                ? service.GetMany()
                : service.Find(txtSearch.Text);
            var contactVMs = contacts.Select((item, i) =>
            {
                var contactVM = ContactVM.From(item);
                contactVM.SerialNo = i + 1;
                return contactVM;
            }).ToList();

            dgvContact.DataSource = contactVMs;
        }

        private void BindContactDetails(ContactVM contactVM)
        {
            txtFirstName.Text = contactVM.FirstName;
            txtLastName.Text = contactVM.LastName;
            txtPhoneNo.Text = contactVM.PhoneNo;
            txtEmail.Text = contactVM.Email;
            rtbAddress.Text = contactVM.Address;
            txtWebsite.Text = contactVM.Website;
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

                // TODO: write to log file
                Console.WriteLine(ex.Message);
            }
        }
    }
}
