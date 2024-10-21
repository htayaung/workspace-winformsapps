namespace QuickNotes.UI.Controls
{
    partial class NoteViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            rtbContent = new RichTextBox();
            pnlFooter = new Panel();
            btnDelete = new Button();
            btnArchive = new Button();
            btnEdit = new Button();
            pnlMain = new Panel();
            toolTip = new ToolTip(components);
            pnlFooter.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Margin = new Padding(3, 0, 3, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // rtbContent
            // 
            rtbContent.BackColor = SystemColors.ControlLightLight;
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.Location = new Point(0, 46);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(354, 241);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            rtbContent.MouseEnter += NoteViewControl_MouseHover;
            rtbContent.MouseHover += NoteViewControl_MouseHover;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnDelete);
            pnlFooter.Controls.Add(btnArchive);
            pnlFooter.Controls.Add(btnEdit);
            pnlFooter.Location = new Point(3, 293);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(5);
            pnlFooter.Size = new Size(354, 64);
            pnlFooter.TabIndex = 2;
            pnlFooter.MouseEnter += NoteViewControl_MouseHover;
            pnlFooter.MouseHover += NoteViewControl_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.recycle_bin_line_icon;
            btnDelete.Location = new Point(296, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 2;
            toolTip.SetToolTip(btnDelete, "Delete");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnArchive
            // 
            btnArchive.FlatAppearance.BorderSize = 0;
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Image = Properties.Resources.archive_line_icon;
            btnArchive.Location = new Point(240, 7);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(50, 50);
            btnArchive.TabIndex = 1;
            toolTip.SetToolTip(btnArchive, "Archive");
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += BtnArchive_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.edit_document_icon;
            btnEdit.Location = new Point(184, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(50, 50);
            btnEdit.TabIndex = 0;
            toolTip.SetToolTip(btnEdit, "Edit");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(pnlFooter);
            pnlMain.Controls.Add(rtbContent);
            pnlMain.Location = new Point(23, 23);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(354, 352);
            pnlMain.TabIndex = 3;
            // 
            // NoteViewControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            Name = "NoteViewControl";
            Padding = new Padding(20);
            Size = new Size(400, 400);
            MouseEnter += NoteViewControl_MouseHover;
            MouseLeave += NoteViewControl_MousLeave;
            MouseHover += NoteViewControl_MouseHover;
            pnlFooter.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtbContent;
        private Panel pnlFooter;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnArchive;
        private Panel pnlMain;
        private ToolTip toolTip;
    }
}
