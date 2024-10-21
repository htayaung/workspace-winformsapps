using QuickNotes.UI.ViewModels;

namespace QuickNotes.UI.Controls
{
    public partial class NoteViewControl : UserControl
    {
        #region Private Variables

        private int id
        {
            get; set;
        }

        private string title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        private string content
        {
            get
            {
                return rtbContent.Text;
            }
            set
            {
                rtbContent.Text = value;
            }
        }

        private bool isArchived
        {
            get; set;
        }

        private bool isDeleted
        {
            get; set;
        }

        #endregion

        #region Public Event Handlers

        public event EventHandler? EditButtonClicked;
        public event EventHandler? ArchiveButtonClicked;
        public event EventHandler? DeleteButtonClicked;

        #endregion

        #region Constructor

        public NoteViewControl()
        {
            InitializeComponent();
            pnlFooter.Visible = false;
        }

        #endregion

        #region Public Methods

        public void SetParams(NoteViewModel noteVM)
        {
            id = noteVM.Id;
            title = noteVM.Title;
            content = noteVM.Content;
            isArchived = noteVM.IsArchived;
            isDeleted = noteVM.IsDeleted;
        }

        public NoteViewModel GetData()
        {
            return new NoteViewModel
            {
                Id = id,
                Title = title,
                Content = content,
                IsArchived = isArchived,
                IsDeleted = isDeleted,
            };
        }

        #endregion

        #region Control Events

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            ArchiveButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void NoteViewControl_MouseHover(object sender, EventArgs e)
        {
            pnlFooter.Visible = true;

            if (isArchived)
            {
                btnArchive.Enabled = false;
            }

            if (isDeleted)
            {
                btnDelete.Enabled = false;
            }
        }

        private void NoteViewControl_MousLeave(object sender, EventArgs e)
        {
            pnlFooter.Visible = false;
        }

        #endregion
    }
}
