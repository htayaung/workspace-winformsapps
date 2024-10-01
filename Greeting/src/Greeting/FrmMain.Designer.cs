namespace Greeting
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            errorMessageProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorMessageProvider).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(97, 52);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(234, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(98, 101);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(234, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 27);
            txtLastName.TabIndex = 3;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(234, 145);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 46);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(183, 52);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 5;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(183, 101);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 6;
            label2.Text = "*";
            // 
            // errorMessageProvider
            // 
            errorMessageProvider.ContainerControl = this;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "FrmMain";
            Text = "Greeting 👋";
            ((System.ComponentModel.ISupportInitialize)errorMessageProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private ErrorProvider errorMessageProvider;
    }
}
