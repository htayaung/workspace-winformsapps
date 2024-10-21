using Microsoft.Extensions.Logging;
using QuickNotes.Core.Interfaces;
using QuickNotes.UI.Controls;
using QuickNotes.UI.ViewModels;
using System.Diagnostics;

namespace QuickNotes.UI
{
    public partial class FrmMain : Form
    {
        private readonly ILogger<FrmMain> logger;
        private readonly INoteService service;

        #region Private Variables

        private int id
        {
            get; set;
        }

        private string title
        {
            get
            {
                return txtTitle.Text;
            }
            set
            {
                txtTitle.Text = value;
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

        private NoteViewControl? selectedNoteView;

        #endregion

        #region Constructor

        public FrmMain(
            ILogger<FrmMain> logger,
            INoteService service)
        {
            InitializeComponent();

            this.logger = logger;
            this.service = service;
        }

        #endregion

        #region Control Events

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            logger.LogInformation("Main form load");
            await TryExecuteAsync(BindNotes);
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                if (!TryValidateInputs())
                {
                    return;
                }

                var noteVM = new NoteViewModel
                {
                    Id = id,
                    Title = title,
                    Content = content,
                    IsArchived = isArchived,
                    IsDeleted = isDeleted
                };

                if (selectedNoteView == null)
                {
                    await service.AddAsync(noteVM);
                    logger.LogInformation($"Saved: {noteVM.ToJson()}");

                    NoteViewControl noteView = new();
                    noteView.SetParams(noteVM);
                    AddNoteViewControlEventHandlers(noteView);
                    pnlNotes.Controls.Add(noteView);

                    if (tabControlNotes.SelectedTab != tabPageNotes)
                    {
                        tabControlNotes.SelectedTab = tabPageNotes;
                    }
                }
                else
                {
                    await service.UpdateAsync(noteVM);
                    selectedNoteView.SetParams(noteVM);
                    logger.LogInformation($"Updated : {noteVM.ToJson()}");
                }

                ResetForm();
            });
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateTextValue(title, txtTitle);
        }

        private void RtbContent_TextChanged(object sender, EventArgs e)
        {
            ValidateTextValue(content, rtbContent);
        }

        private async void NoteViewControl_EditButtonClicked(object? sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                await Task.Run(() =>
                {
                    if (sender is NoteViewControl)
                    {
                        var noteView = (NoteViewControl)sender;
                        selectedNoteView = noteView;
                        var noteVM = noteView.GetData();
                        id = noteVM.Id;
                        title = noteVM.Title;
                        content = noteVM.Content;
                        isArchived = noteVM.IsArchived;
                        isDeleted = noteVM.IsDeleted;
                    }
                });
            });
        }

        private async void NoteViewControl_ArchiveButtonClicked(object? sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                if (sender is NoteViewControl)
                {
                    var noteView = (NoteViewControl)sender;
                    selectedNoteView = noteView;
                    var noteVM = noteView.GetData();
                    noteVM.IsArchived = true;
                    noteVM.IsDeleted = false;
                    await service.UpdateAsync(noteVM);
                    logger.LogInformation($"Archived : {noteVM.ToJson()}");

                    RemoveNoteViewControl(noteView);
                    selectedNoteView = null;
                    ResetForm();
                }
            });
        }

        private async void NoteViewControl_DeleteButtonClicked(object? sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                if (sender is NoteViewControl)
                {
                    var NoteViewControl = (NoteViewControl)sender;
                    selectedNoteView = NoteViewControl;
                    var noteVM = NoteViewControl.GetData();
                    var confirmation = MessageBox.Show(
                        "Are you sure you want to delete this note?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        noteVM.IsArchived = false;
                        noteVM.IsDeleted = true;

                        await service.UpdateAsync(noteVM);
                        logger.LogInformation($"Deleted : {noteVM.ToJson()}");

                        RemoveNoteViewControl(NoteViewControl);
                        selectedNoteView = null;
                        ResetForm();
                    }
                }
            });
        }

        private async void TabControlNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                if (tabControlNotes.SelectedTab == tabPageNotes)
                {
                    await BindNotes();
                }
                else if (tabControlNotes.SelectedTab == tabPageArchive)
                {
                    await BindArchivedNotes();
                }
                else if (tabControlNotes.SelectedTab == tabPageTrash)
                {
                    await BindDeletedNotes();
                }
            });
        }

        private async void BtnEmptyTrash_Click(object sender, EventArgs e)
        {
            await TryExecuteAsync(async () =>
            {
                var deleteConfirmation = MessageBox.Show(
                    "All notes in trash will be permanently deleted. Are you sure you want to proceed?",
                    "Important",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (deleteConfirmation == DialogResult.Yes)
                {
                    await service.EmptyTrashAsync();
                    logger.LogInformation("Empty trash");
                    pnlDeletedNotes.Controls.Clear();
                    btnEmptyTrash.Enabled = false;
                }
            });
        }

        private void LblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TryExecute(() =>
            {
                lblAuthor.LinkVisited = true;
                var processInfo = new ProcessStartInfo("https://github.com/htayaung")
                {
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            });
        }

        #endregion

        #region Private Methods

        private async Task BindNotes()
        {
            var notes = await service.GetCurrentNotesAsync();
            var noteVMs = NoteViewModel.From(notes);
            pnlNotes.Controls.Clear();
            foreach (var noteVM in noteVMs)
            {
                NoteViewControl noteView = new();
                noteView.SetParams(noteVM);
                AddNoteViewControlEventHandlers(noteView);
                pnlNotes.Controls.Add(noteView);
            }
        }

        private async Task BindArchivedNotes()
        {
            var notes = await service.GetArchivedNotesAsync();
            var noteVMs = NoteViewModel.From(notes);
            pnlArchivedNotes.Controls.Clear();
            foreach (var noteVM in noteVMs)
            {
                NoteViewControl control = new();
                control.SetParams(noteVM);
                AddNoteViewControlEventHandlers(control);
                pnlArchivedNotes.Controls.Add(control);
            }
        }

        private async Task BindDeletedNotes()
        {
            var notes = await service.GetDeletedNotesAsync();
            var noteVMs = NoteViewModel.From(notes);
            pnlDeletedNotes.Controls.Clear();
            foreach (var noteVM in noteVMs)
            {
                NoteViewControl control = new();
                control.SetParams(noteVM);
                AddNoteViewControlEventHandlers(control);
                pnlDeletedNotes.Controls.Add(control);
            }

            btnEmptyTrash.Enabled = noteVMs.Count() > 0;
        }

        private bool TryValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                SetRequiredFieldErrorMessage(txtTitle);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(content))
            {
                SetRequiredFieldErrorMessage(rtbContent);
                rtbContent.Focus();
                return false;
            }

            return true;
        }

        private void SetRequiredFieldErrorMessage(
            Control control,
            string message = "This field is required")
        {
            errorProvider.SetError(control, message);
        }

        private void ValidateTextValue(
            string value,
            Control control)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                SetRequiredFieldErrorMessage(control);
            }
            else
            {
                SetRequiredFieldErrorMessage(control, string.Empty);
            }
        }

        private void ResetForm()
        {
            id = default;
            title = string.Empty;
            content = string.Empty;
            selectedNoteView = null;
            SetRequiredFieldErrorMessage(txtTitle, string.Empty);
            SetRequiredFieldErrorMessage(rtbContent, string.Empty);
        }

        private void RemoveNoteViewControl(NoteViewControl control)
        {
            var parentControl = control.Parent;
            if (parentControl == pnlNotes)
            {
                pnlNotes.Controls.Remove(control);
            }
            else if (parentControl == pnlArchivedNotes)
            {
                pnlArchivedNotes.Controls.Remove(control);
            }
            else if (parentControl == pnlDeletedNotes)
            {
                pnlDeletedNotes.Controls.Remove(control);
            }
        }

        private void AddNoteViewControlEventHandlers(NoteViewControl control)
        {
            control.EditButtonClicked += NoteViewControl_EditButtonClicked;
            control.ArchiveButtonClicked += NoteViewControl_ArchiveButtonClicked;
            control.DeleteButtonClicked += NoteViewControl_DeleteButtonClicked;
        }

        private async Task TryExecuteAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while processing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                logger.LogError(ex.Message);
            }
        }

        private void TryExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while processing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                logger.LogError(ex.Message);
            }
        }

        #endregion
    }
}
