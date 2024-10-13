namespace ContactManager
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
            lblDetailedInformation = new Label();
            pnlFooter = new Panel();
            btnDelete = new Button();
            imageList = new ImageList(components);
            btnEdit = new Button();
            btnNew = new Button();
            dgvContact = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colSN = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPhoneNo = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlSearch = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblHeader = new Label();
            tblPanelMain = new TableLayoutPanel();
            pnlDetailedInformation = new Panel();
            rtbAddress = new RichTextBox();
            txtWebsite = new TextBox();
            lblWebsite = new Label();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNo = new TextBox();
            lblPhoneNo = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            pnlSearch.SuspendLayout();
            tblPanelMain.SuspendLayout();
            pnlDetailedInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblDetailedInformation
            // 
            lblDetailedInformation.Dock = DockStyle.Left;
            lblDetailedInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailedInformation.Location = new Point(811, 85);
            lblDetailedInformation.Name = "lblDetailedInformation";
            lblDetailedInformation.Size = new Size(412, 73);
            lblDetailedInformation.TabIndex = 4;
            lblDetailedInformation.Text = "Detailed Information";
            lblDetailedInformation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnDelete);
            pnlFooter.Controls.Add(btnEdit);
            pnlFooter.Controls.Add(btnNew);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(3, 637);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(802, 81);
            pnlFooter.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.ImageKey = "recycle-bin-icon.png";
            btnDelete.ImageList = imageList;
            btnDelete.Location = new Point(676, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "search-icon.png");
            imageList.Images.SetKeyName(1, "plus-icon.png");
            imageList.Images.SetKeyName(2, "pencil-icon.png");
            imageList.Images.SetKeyName(3, "recycle-bin-icon.png");
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.ImageKey = "pencil-icon.png";
            btnEdit.ImageList = imageList;
            btnEdit.Location = new Point(547, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.ImageKey = "plus-icon.png";
            btnNew.ImageList = imageList;
            btnNew.Location = new Point(418, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(123, 50);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvContact
            // 
            dgvContact.AllowUserToAddRows = false;
            dgvContact.AllowUserToDeleteRows = false;
            dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContact.BackgroundColor = SystemColors.Control;
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Columns.AddRange(new DataGridViewColumn[] { colId, colSN, colFirstName, colLastName, colPhoneNo, colEmail });
            dgvContact.Dock = DockStyle.Fill;
            dgvContact.Location = new Point(3, 161);
            dgvContact.Name = "dgvContact";
            dgvContact.RowHeadersVisible = false;
            dgvContact.RowHeadersWidth = 51;
            dgvContact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContact.Size = new Size(802, 470);
            dgvContact.TabIndex = 2;
            dgvContact.SelectionChanged += dgvContact_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colSN
            // 
            colSN.DataPropertyName = "SerialNo";
            colSN.HeaderText = "#";
            colSN.MinimumWidth = 6;
            colSN.Name = "colSN";
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            // 
            // colPhoneNo
            // 
            colPhoneNo.DataPropertyName = "PhoneNo";
            colPhoneNo.HeaderText = "Phone No";
            colPhoneNo.MinimumWidth = 6;
            colPhoneNo.Name = "colPhoneNo";
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // pnlSearch
            // 
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(3, 88);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(0, 10, 0, 10);
            pnlSearch.Size = new Size(802, 67);
            pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ImageKey = "search-icon.png";
            btnSearch.ImageList = imageList;
            btnSearch.Location = new Point(752, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 35);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(78, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(668, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(11, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.MidnightBlue;
            tblPanelMain.SetColumnSpan(lblHeader, 2);
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1342, 85);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Contact Manager";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblPanelMain
            // 
            tblPanelMain.ColumnCount = 2;
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblPanelMain.Controls.Add(lblHeader, 0, 0);
            tblPanelMain.Controls.Add(pnlSearch, 0, 1);
            tblPanelMain.Controls.Add(dgvContact, 0, 2);
            tblPanelMain.Controls.Add(pnlFooter, 0, 3);
            tblPanelMain.Controls.Add(lblDetailedInformation, 1, 1);
            tblPanelMain.Controls.Add(pnlDetailedInformation, 1, 2);
            tblPanelMain.Dock = DockStyle.Fill;
            tblPanelMain.Location = new Point(0, 0);
            tblPanelMain.Name = "tblPanelMain";
            tblPanelMain.RowCount = 4;
            tblPanelMain.RowStyles.Add(new RowStyle());
            tblPanelMain.RowStyles.Add(new RowStyle());
            tblPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPanelMain.RowStyles.Add(new RowStyle());
            tblPanelMain.Size = new Size(1348, 721);
            tblPanelMain.TabIndex = 0;
            // 
            // pnlDetailedInformation
            // 
            pnlDetailedInformation.AutoScroll = true;
            pnlDetailedInformation.Controls.Add(rtbAddress);
            pnlDetailedInformation.Controls.Add(txtWebsite);
            pnlDetailedInformation.Controls.Add(lblWebsite);
            pnlDetailedInformation.Controls.Add(lblAddress);
            pnlDetailedInformation.Controls.Add(txtEmail);
            pnlDetailedInformation.Controls.Add(lblEmail);
            pnlDetailedInformation.Controls.Add(txtPhoneNo);
            pnlDetailedInformation.Controls.Add(lblPhoneNo);
            pnlDetailedInformation.Controls.Add(txtLastName);
            pnlDetailedInformation.Controls.Add(lblLastName);
            pnlDetailedInformation.Controls.Add(txtFirstName);
            pnlDetailedInformation.Controls.Add(lblFirstName);
            pnlDetailedInformation.Dock = DockStyle.Fill;
            pnlDetailedInformation.Location = new Point(811, 161);
            pnlDetailedInformation.Name = "pnlDetailedInformation";
            pnlDetailedInformation.Size = new Size(534, 470);
            pnlDetailedInformation.TabIndex = 5;
            // 
            // rtbAddress
            // 
            rtbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbAddress.Location = new Point(214, 273);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.ReadOnly = true;
            rtbAddress.Size = new Size(275, 102);
            rtbAddress.TabIndex = 12;
            rtbAddress.Text = "";
            // 
            // txtWebsite
            // 
            txtWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWebsite.Location = new Point(214, 404);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.ReadOnly = true;
            txtWebsite.Size = new Size(275, 30);
            txtWebsite.TabIndex = 11;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(87, 408);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(70, 23);
            lblWebsite.TabIndex = 10;
            lblWebsite.Text = "Website";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(87, 273);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(214, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(275, 30);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(106, 218);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNo.Location = new Point(214, 155);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.ReadOnly = true;
            txtPhoneNo.Size = new Size(275, 30);
            txtPhoneNo.TabIndex = 5;
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Location = new Point(66, 159);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(91, 23);
            lblPhoneNo.TabIndex = 4;
            lblPhoneNo.Text = "Phone No.";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(214, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(275, 30);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(66, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(214, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(275, 30);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(65, 41);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(tblPanelMain);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Contact Manager";
            Load += FrmMain_Load;
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            tblPanelMain.ResumeLayout(false);
            pnlDetailedInformation.ResumeLayout(false);
            pnlDetailedInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDetailedInformation;
        private Panel pnlFooter;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private DataGridView dgvContact;
        private Panel pnlSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblHeader;
        private TableLayoutPanel tblPanelMain;
        private Panel pnlDetailedInformation;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhoneNo;
        private Label lblPhoneNo;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtWebsite;
        private Label lblWebsite;
        private Label lblAddress;
        private RichTextBox rtbAddress;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colSN;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPhoneNo;
        private DataGridViewTextBoxColumn colEmail;
        private ImageList imageList;
    }
}
