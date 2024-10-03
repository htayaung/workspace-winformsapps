namespace BMICalculator
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
            lblHeader = new Label();
            lblWeight = new Label();
            lblHeight = new Label();
            txtWeight = new TextBox();
            cboWeightUnit = new ComboBox();
            txtHeight = new TextBox();
            cboHeightUnit = new ComboBox();
            label1 = new Label();
            btnCalculate = new Button();
            pnlResult = new Panel();
            lblRiskTypeResult = new Label();
            lblClassificationResult = new Label();
            lblRiskType = new Label();
            lblClassification = new Label();
            lblResult = new Label();
            cboHeightInFeet = new ComboBox();
            cboHeightInInch = new ComboBox();
            pnlResult.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.MidnightBlue;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1006, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Calculate your Body Mass Index";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(135, 103);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(81, 25);
            lblWeight.TabIndex = 1;
            lblWeight.Text = "Weight :";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(135, 184);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(77, 25);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height :";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(280, 99);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 32);
            txtWeight.TabIndex = 3;
            txtWeight.TextChanged += txtWeight_TextChanged;
            txtWeight.KeyPress += txtWeight_KeyPress;
            // 
            // cboWeightUnit
            // 
            cboWeightUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeightUnit.FormattingEnabled = true;
            cboWeightUnit.Location = new Point(386, 99);
            cboWeightUnit.Name = "cboWeightUnit";
            cboWeightUnit.Size = new Size(100, 33);
            cboWeightUnit.TabIndex = 4;
            cboWeightUnit.SelectedIndexChanged += cboWeightUnit_SelectedIndexChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(574, 180);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 32);
            txtHeight.TabIndex = 7;
            txtHeight.TextChanged += txtHeight_TextChanged;
            txtHeight.KeyPress += txtHeight_KeyPress;
            // 
            // cboHeightUnit
            // 
            cboHeightUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightUnit.FormattingEnabled = true;
            cboHeightUnit.Location = new Point(680, 180);
            cboHeightUnit.Name = "cboHeightUnit";
            cboHeightUnit.Size = new Size(100, 33);
            cboHeightUnit.TabIndex = 8;
            cboHeightUnit.SelectedIndexChanged += cboHeightUnit_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 184);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 9;
            label1.Text = "or";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.MidnightBlue;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(280, 259);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(206, 51);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pnlResult
            // 
            pnlResult.Controls.Add(lblRiskTypeResult);
            pnlResult.Controls.Add(lblClassificationResult);
            pnlResult.Controls.Add(lblRiskType);
            pnlResult.Controls.Add(lblClassification);
            pnlResult.Controls.Add(lblResult);
            pnlResult.Dock = DockStyle.Bottom;
            pnlResult.Location = new Point(0, 361);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(1006, 360);
            pnlResult.TabIndex = 11;
            // 
            // lblRiskTypeResult
            // 
            lblRiskTypeResult.AutoSize = true;
            lblRiskTypeResult.Location = new Point(603, 145);
            lblRiskTypeResult.Name = "lblRiskTypeResult";
            lblRiskTypeResult.Size = new Size(155, 25);
            lblRiskTypeResult.TabIndex = 4;
            lblRiskTypeResult.Text = "lblRiskTypeResult";
            // 
            // lblClassificationResult
            // 
            lblClassificationResult.AutoSize = true;
            lblClassificationResult.Location = new Point(418, 88);
            lblClassificationResult.Name = "lblClassificationResult";
            lblClassificationResult.Size = new Size(194, 25);
            lblClassificationResult.TabIndex = 3;
            lblClassificationResult.Text = "lblClassificationResult";
            // 
            // lblRiskType
            // 
            lblRiskType.AutoSize = true;
            lblRiskType.Location = new Point(280, 145);
            lblRiskType.Name = "lblRiskType";
            lblRiskType.Size = new Size(317, 25);
            lblRiskType.TabIndex = 2;
            lblRiskType.Text = "Risk of developing health problems :";
            // 
            // lblClassification
            // 
            lblClassification.AutoSize = true;
            lblClassification.Location = new Point(280, 88);
            lblClassification.Name = "lblClassification";
            lblClassification.Size = new Size(132, 25);
            lblClassification.TabIndex = 1;
            lblClassification.Text = "Classification :";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(280, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 25);
            lblResult.TabIndex = 0;
            lblResult.Text = "lblResult";
            // 
            // cboHeightInFeet
            // 
            cboHeightInFeet.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightInFeet.FormattingEnabled = true;
            cboHeightInFeet.Location = new Point(280, 180);
            cboHeightInFeet.Name = "cboHeightInFeet";
            cboHeightInFeet.Size = new Size(100, 33);
            cboHeightInFeet.TabIndex = 12;
            cboHeightInFeet.SelectedIndexChanged += cboHeightInFeet_SelectedIndexChanged;
            // 
            // cboHeightInInch
            // 
            cboHeightInInch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightInInch.FormattingEnabled = true;
            cboHeightInInch.Location = new Point(386, 180);
            cboHeightInInch.Name = "cboHeightInInch";
            cboHeightInInch.Size = new Size(100, 33);
            cboHeightInInch.TabIndex = 13;
            cboHeightInInch.SelectedIndexChanged += cboHeightInInch_SelectedIndexChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(cboHeightInInch);
            Controls.Add(cboHeightInFeet);
            Controls.Add(pnlResult);
            Controls.Add(btnCalculate);
            Controls.Add(label1);
            Controls.Add(cboHeightUnit);
            Controls.Add(txtHeight);
            Controls.Add(cboWeightUnit);
            Controls.Add(txtWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "BMI Calculator";
            Load += FrmMain_Load;
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblWeight;
        private Label lblHeight;
        private TextBox txtWeight;
        private ComboBox cboWeightUnit;
        private TextBox txtHeight;
        private ComboBox cboHeightUnit;
        private Label label1;
        private Button btnCalculate;
        private Panel pnlResult;
        private Label lblResult;
        private Label lblRiskType;
        private Label lblClassification;
        private Label lblRiskTypeResult;
        private Label lblClassificationResult;
        private ComboBox cboHeightInFeet;
        private ComboBox cboHeightInInch;
    }
}
