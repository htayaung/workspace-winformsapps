namespace ContactManager
{
    partial class FrmSaveContact
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaveContact));
            pnlContactInformation = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblHeader = new Label();
            btnClose = new Button();
            btnSave = new Button();
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
            errorMessageProvider = new ErrorProvider(components);
            imageList = new ImageList(components);
            pnlContactInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessageProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlContactInformation
            // 
            pnlContactInformation.AutoScroll = true;
            pnlContactInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlContactInformation.Controls.Add(label4);
            pnlContactInformation.Controls.Add(label3);
            pnlContactInformation.Controls.Add(label2);
            pnlContactInformation.Controls.Add(label1);
            pnlContactInformation.Controls.Add(lblHeader);
            pnlContactInformation.Controls.Add(btnClose);
            pnlContactInformation.Controls.Add(btnSave);
            pnlContactInformation.Controls.Add(rtbAddress);
            pnlContactInformation.Controls.Add(txtWebsite);
            pnlContactInformation.Controls.Add(lblWebsite);
            pnlContactInformation.Controls.Add(lblAddress);
            pnlContactInformation.Controls.Add(txtEmail);
            pnlContactInformation.Controls.Add(lblEmail);
            pnlContactInformation.Controls.Add(txtPhoneNo);
            pnlContactInformation.Controls.Add(lblPhoneNo);
            pnlContactInformation.Controls.Add(txtLastName);
            pnlContactInformation.Controls.Add(lblLastName);
            pnlContactInformation.Controls.Add(txtFirstName);
            pnlContactInformation.Controls.Add(lblFirstName);
            pnlContactInformation.Dock = DockStyle.Fill;
            pnlContactInformation.Location = new Point(0, 0);
            pnlContactInformation.Name = "pnlContactInformation";
            pnlContactInformation.Size = new Size(749, 609);
            pnlContactInformation.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(124, 339);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(124, 225);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(124, 166);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(124, 107);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 16;
            label1.Text = "*";
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(40, 0, 0, 0);
            lblHeader.Size = new Size(747, 86);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "Save Contact";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.ImageKey = "close-icon.png";
            btnClose.ImageList = imageList;
            btnClose.Location = new Point(568, 534);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 50);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.ImageKey = "check-mark-icon.png";
            btnSave.ImageList = imageList;
            btnSave.Location = new Point(433, 534);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 50);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtbAddress
            // 
            rtbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbAddress.Location = new Point(197, 339);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(498, 102);
            rtbAddress.TabIndex = 12;
            rtbAddress.Text = "";
            rtbAddress.TextChanged += TextInput_TextChanged;
            // 
            // txtWebsite
            // 
            txtWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWebsite.Location = new Point(197, 470);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(498, 27);
            txtWebsite.TabIndex = 11;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(66, 474);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(62, 20);
            lblWebsite.TabIndex = 10;
            lblWebsite.Text = "Website";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(66, 339);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(197, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(498, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(82, 284);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNo.Location = new Point(197, 221);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(498, 27);
            txtPhoneNo.TabIndex = 5;
            txtPhoneNo.TextChanged += TextInput_TextChanged;
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Location = new Point(51, 225);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(77, 20);
            lblPhoneNo.TabIndex = 4;
            lblPhoneNo.Text = "Phone No.";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(197, 162);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(498, 27);
            txtLastName.TabIndex = 3;
            txtLastName.TextChanged += TextInput_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(49, 166);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(197, 103);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(498, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += TextInput_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(48, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // errorMessageProvider
            // 
            errorMessageProvider.ContainerControl = this;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "check-mark-icon.png");
            imageList.Images.SetKeyName(1, "close-icon.png");
            // 
            // FrmSaveContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 609);
            Controls.Add(pnlContactInformation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSaveContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSaveContact";
            pnlContactInformation.ResumeLayout(false);
            pnlContactInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessageProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContactInformation;
        private RichTextBox rtbAddress;
        private TextBox txtWebsite;
        private Label lblWebsite;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhoneNo;
        private Label lblPhoneNo;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnClose;
        private Button btnSave;
        private Label lblHeader;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider errorMessageProvider;
        private ImageList imageList;
    }
}