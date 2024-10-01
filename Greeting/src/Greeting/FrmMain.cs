namespace Greeting
{
    public partial class FrmMain : Form
    {
        private string firstName
        {
            get
            {
                return txtFirstName.Text;
            }
        }

        private string lastName
        {
            get
            {
                return txtLastName.Text;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Control Events

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            var message = $"Hi, {firstName} {lastName}. How are you?";

            var result = MessageBox.Show(message, "Greeting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("I'm glad to hear that.", "Happy 😊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("I'm so sorry to hear that.", "Sad 😢", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                SetRequiredFieldErrorMessage(txtFirstName);
            }
            else
            {
                SetRequiredFieldErrorMessage(txtFirstName, string.Empty);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                SetRequiredFieldErrorMessage(txtLastName);
            }
            else
            {
                SetRequiredFieldErrorMessage(txtLastName, string.Empty);
            }
        }

        #endregion

        #region Private Methods

        private bool ValidateInputs()
        {
            int invalidControlCount = default;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                SetRequiredFieldErrorMessage(txtFirstName);
                invalidControlCount += 1;
            }
            else
            {
                SetRequiredFieldErrorMessage(txtFirstName, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                SetRequiredFieldErrorMessage(txtLastName);
                invalidControlCount += 1;
            }
            else
            {
                SetRequiredFieldErrorMessage(txtLastName, string.Empty);
            }

            return invalidControlCount == 0;
        }

        private void SetRequiredFieldErrorMessage(
            Control control,
            string message = "This field is required.")
        {
            errorMessageProvider.SetError(control, message);
        }

        #endregion
    }
}
