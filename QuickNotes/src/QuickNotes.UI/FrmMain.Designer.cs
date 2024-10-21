namespace QuickNotes.UI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tableLayoutMain = new TableLayoutPanel();
            pnlSetup = new Panel();
            btnSave = new Button();
            rtbContent = new RichTextBox();
            lblContent = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            tabControlNotes = new TabControl();
            tabPageNotes = new TabPage();
            pnlNotes = new FlowLayoutPanel();
            tabPageArchive = new TabPage();
            pnlArchivedNotes = new FlowLayoutPanel();
            tabPageTrash = new TabPage();
            btnEmptyTrash = new Button();
            pnlDeletedNotes = new FlowLayoutPanel();
            tabImageList = new ImageList(components);
            pnlHeader = new Panel();
            lblAuthor = new LinkLabel();
            lblHeader = new Label();
            errorProvider = new ErrorProvider(components);
            btnReset = new Button();
            tableLayoutMain.SuspendLayout();
            pnlSetup.SuspendLayout();
            tabControlNotes.SuspendLayout();
            tabPageNotes.SuspendLayout();
            tabPageArchive.SuspendLayout();
            tabPageTrash.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutMain.Controls.Add(pnlSetup, 0, 1);
            tableLayoutMain.Controls.Add(tabControlNotes, 1, 1);
            tableLayoutMain.Controls.Add(pnlHeader, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle());
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1348, 721);
            tableLayoutMain.TabIndex = 0;
            // 
            // pnlSetup
            // 
            pnlSetup.Controls.Add(btnReset);
            pnlSetup.Controls.Add(btnSave);
            pnlSetup.Controls.Add(rtbContent);
            pnlSetup.Controls.Add(lblContent);
            pnlSetup.Controls.Add(txtTitle);
            pnlSetup.Controls.Add(lblTitle);
            pnlSetup.Dock = DockStyle.Fill;
            pnlSetup.Location = new Point(3, 84);
            pnlSetup.Margin = new Padding(3, 3, 3, 5);
            pnlSetup.Name = "pnlSetup";
            pnlSetup.Padding = new Padding(22, 23, 22, 23);
            pnlSetup.Size = new Size(331, 632);
            pnlSetup.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(6, 540);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 54);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // rtbContent
            // 
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.Location = new Point(26, 187);
            rtbContent.Margin = new Padding(3, 3, 3, 58);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(279, 291);
            rtbContent.TabIndex = 3;
            rtbContent.Text = "";
            rtbContent.TextChanged += RtbContent_TextChanged;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(26, 150);
            lblContent.Margin = new Padding(3, 0, 3, 12);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(72, 23);
            lblContent.TabIndex = 2;
            lblContent.Text = "Content";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(26, 61);
            txtTitle.Margin = new Padding(3, 3, 3, 58);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(279, 30);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(26, 23);
            lblTitle.Margin = new Padding(3, 0, 3, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // tabControlNotes
            // 
            tabControlNotes.Controls.Add(tabPageNotes);
            tabControlNotes.Controls.Add(tabPageArchive);
            tabControlNotes.Controls.Add(tabPageTrash);
            tabControlNotes.Dock = DockStyle.Fill;
            tabControlNotes.ImageList = tabImageList;
            tabControlNotes.Location = new Point(337, 81);
            tabControlNotes.Margin = new Padding(0);
            tabControlNotes.Name = "tabControlNotes";
            tabControlNotes.Padding = new Point(10, 10);
            tabControlNotes.SelectedIndex = 0;
            tabControlNotes.Size = new Size(1011, 640);
            tabControlNotes.TabIndex = 1;
            tabControlNotes.SelectedIndexChanged += TabControlNotes_SelectedIndexChanged;
            // 
            // tabPageNotes
            // 
            tabPageNotes.BackColor = SystemColors.Control;
            tabPageNotes.Controls.Add(pnlNotes);
            tabPageNotes.ImageKey = "edit-document-icon.png";
            tabPageNotes.Location = new Point(4, 53);
            tabPageNotes.Margin = new Padding(0);
            tabPageNotes.Name = "tabPageNotes";
            tabPageNotes.Padding = new Padding(3);
            tabPageNotes.Size = new Size(1003, 583);
            tabPageNotes.TabIndex = 0;
            tabPageNotes.Text = "Notes";
            // 
            // pnlNotes
            // 
            pnlNotes.AutoScroll = true;
            pnlNotes.BackColor = SystemColors.Control;
            pnlNotes.Dock = DockStyle.Fill;
            pnlNotes.Location = new Point(3, 3);
            pnlNotes.Margin = new Padding(0);
            pnlNotes.Name = "pnlNotes";
            pnlNotes.Size = new Size(997, 577);
            pnlNotes.TabIndex = 0;
            // 
            // tabPageArchive
            // 
            tabPageArchive.BackColor = SystemColors.Control;
            tabPageArchive.Controls.Add(pnlArchivedNotes);
            tabPageArchive.ImageKey = "archive-line-icon.png";
            tabPageArchive.Location = new Point(4, 53);
            tabPageArchive.Name = "tabPageArchive";
            tabPageArchive.Padding = new Padding(3);
            tabPageArchive.Size = new Size(1003, 583);
            tabPageArchive.TabIndex = 1;
            tabPageArchive.Text = "Archived";
            // 
            // pnlArchivedNotes
            // 
            pnlArchivedNotes.AutoScroll = true;
            pnlArchivedNotes.BackColor = SystemColors.Control;
            pnlArchivedNotes.Dock = DockStyle.Fill;
            pnlArchivedNotes.Location = new Point(3, 3);
            pnlArchivedNotes.Margin = new Padding(0);
            pnlArchivedNotes.Name = "pnlArchivedNotes";
            pnlArchivedNotes.Size = new Size(997, 577);
            pnlArchivedNotes.TabIndex = 1;
            // 
            // tabPageTrash
            // 
            tabPageTrash.BackColor = SystemColors.Control;
            tabPageTrash.Controls.Add(btnEmptyTrash);
            tabPageTrash.Controls.Add(pnlDeletedNotes);
            tabPageTrash.ImageKey = "recycle-bin-line-icon.png";
            tabPageTrash.Location = new Point(4, 53);
            tabPageTrash.Name = "tabPageTrash";
            tabPageTrash.Padding = new Padding(3);
            tabPageTrash.Size = new Size(1003, 583);
            tabPageTrash.TabIndex = 2;
            tabPageTrash.Text = "Deleted";
            // 
            // btnEmptyTrash
            // 
            btnEmptyTrash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmptyTrash.BackColor = Color.Red;
            btnEmptyTrash.FlatStyle = FlatStyle.Flat;
            btnEmptyTrash.ForeColor = Color.White;
            btnEmptyTrash.Location = new Point(836, 6);
            btnEmptyTrash.Name = "btnEmptyTrash";
            btnEmptyTrash.Size = new Size(151, 50);
            btnEmptyTrash.TabIndex = 6;
            btnEmptyTrash.Text = "Empty Trash";
            btnEmptyTrash.UseVisualStyleBackColor = false;
            btnEmptyTrash.Click += BtnEmptyTrash_Click;
            // 
            // pnlDeletedNotes
            // 
            pnlDeletedNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDeletedNotes.AutoScroll = true;
            pnlDeletedNotes.BackColor = SystemColors.Control;
            pnlDeletedNotes.Location = new Point(3, 59);
            pnlDeletedNotes.Margin = new Padding(0);
            pnlDeletedNotes.Name = "pnlDeletedNotes";
            pnlDeletedNotes.Size = new Size(987, 494);
            pnlDeletedNotes.TabIndex = 1;
            // 
            // tabImageList
            // 
            tabImageList.ColorDepth = ColorDepth.Depth32Bit;
            tabImageList.ImageStream = (ImageListStreamer)resources.GetObject("tabImageList.ImageStream");
            tabImageList.TransparentColor = Color.Transparent;
            tabImageList.Images.SetKeyName(0, "recycle-bin-line-icon.png");
            tabImageList.Images.SetKeyName(1, "archive-line-icon.png");
            tabImageList.Images.SetKeyName(2, "edit-document-icon.png");
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SandyBrown;
            tableLayoutMain.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(lblAuthor);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(10);
            pnlHeader.Size = new Size(1342, 75);
            pnlHeader.TabIndex = 2;
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(1180, 25);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(149, 23);
            lblAuthor.TabIndex = 1;
            lblAuthor.TabStop = true;
            lblAuthor.Text = "GitHub Repository";
            lblAuthor.LinkClicked += LblAuthor_LinkClicked;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.Location = new Point(13, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(190, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Quick Notes";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top;
            btnReset.BackColor = Color.RoyalBlue;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(164, 540);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(152, 54);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(tableLayoutMain);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1024, 768);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quick Notes";
            Load += FrmMain_Load;
            tableLayoutMain.ResumeLayout(false);
            pnlSetup.ResumeLayout(false);
            pnlSetup.PerformLayout();
            tabControlNotes.ResumeLayout(false);
            tabPageNotes.ResumeLayout(false);
            tabPageArchive.ResumeLayout(false);
            tabPageTrash.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Panel pnlSetup;
        private Label lblTitle;
        private RichTextBox rtbContent;
        private Label lblContent;
        private TextBox txtTitle;
        private Button btnSave;
        private TabControl tabControlNotes;
        private TabPage tabPageNotes;
        private TabPage tabPageArchive;
        private TabPage tabPageTrash;
        private FlowLayoutPanel pnlNotes;
        private FlowLayoutPanel pnlArchivedNotes;
        private FlowLayoutPanel pnlDeletedNotes;
        private Button btnEmptyTrash;
        private ImageList tabImageList;
        private ErrorProvider errorProvider;
        private Panel pnlHeader;
        private Label lblHeader;
        private LinkLabel lblAuthor;
        private Button btnReset;
    }
}
