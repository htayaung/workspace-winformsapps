namespace SimpleCalculator
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
            tblPanelMain = new TableLayoutPanel();
            btnEqual = new Button();
            btnClear = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnZero = new Button();
            btnDivision = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            txtResult = new TextBox();
            btnPlus = new Button();
            tblPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblPanelMain
            // 
            tblPanelMain.ColumnCount = 4;
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPanelMain.Controls.Add(btnEqual, 3, 4);
            tblPanelMain.Controls.Add(btnClear, 2, 4);
            tblPanelMain.Controls.Add(btnNine, 1, 4);
            tblPanelMain.Controls.Add(btnEight, 0, 4);
            tblPanelMain.Controls.Add(btnSeven, 3, 3);
            tblPanelMain.Controls.Add(btnSix, 2, 3);
            tblPanelMain.Controls.Add(btnFive, 1, 3);
            tblPanelMain.Controls.Add(btnFour, 0, 3);
            tblPanelMain.Controls.Add(btnThree, 3, 2);
            tblPanelMain.Controls.Add(btnTwo, 2, 2);
            tblPanelMain.Controls.Add(btnOne, 1, 2);
            tblPanelMain.Controls.Add(btnZero, 0, 2);
            tblPanelMain.Controls.Add(btnDivision, 3, 1);
            tblPanelMain.Controls.Add(btnMultiply, 2, 1);
            tblPanelMain.Controls.Add(btnMinus, 1, 1);
            tblPanelMain.Controls.Add(txtResult, 0, 0);
            tblPanelMain.Controls.Add(btnPlus, 0, 1);
            tblPanelMain.Dock = DockStyle.Fill;
            tblPanelMain.Location = new Point(0, 0);
            tblPanelMain.Name = "tblPanelMain";
            tblPanelMain.RowCount = 5;
            tblPanelMain.RowStyles.Add(new RowStyle());
            tblPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblPanelMain.Size = new Size(1006, 721);
            tblPanelMain.TabIndex = 0;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.DarkCyan;
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(756, 559);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(247, 159);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(505, 559);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(245, 159);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnNine.Location = new Point(254, 559);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(245, 159);
            btnNine.TabIndex = 14;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEight.Location = new Point(3, 559);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(245, 159);
            btnEight.TabIndex = 13;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSeven.Location = new Point(756, 396);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(247, 157);
            btnSeven.TabIndex = 12;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSix.Location = new Point(505, 396);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(245, 157);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnFive.Location = new Point(254, 396);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(245, 157);
            btnFive.TabIndex = 10;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnFour.Location = new Point(3, 396);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(245, 157);
            btnFour.TabIndex = 9;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnThree.Location = new Point(756, 233);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(247, 157);
            btnThree.TabIndex = 8;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTwo.Location = new Point(505, 233);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(245, 157);
            btnTwo.TabIndex = 7;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnOne.Location = new Point(254, 233);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(245, 157);
            btnOne.TabIndex = 6;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnZero.Location = new Point(3, 233);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(245, 157);
            btnZero.TabIndex = 5;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.Gray;
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.FlatAppearance.BorderSize = 0;
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDivision.Location = new Point(756, 70);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(247, 157);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Gray;
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnMultiply.Location = new Point(505, 70);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(245, 157);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Gray;
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnMinus.Location = new Point(254, 70);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(245, 157);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblPanelMain.SetColumnSpan(txtResult, 4);
            txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtResult.Location = new Point(3, 3);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(1000, 61);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Gray;
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPlus.Location = new Point(3, 70);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(245, 157);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(tblPanelMain);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Simple Calculator";
            tblPanelMain.ResumeLayout(false);
            tblPanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPanelMain;
        private TextBox txtResult;
        private Button btnPlus;
        private Button btnDivision;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnZero;
        private Button btnEqual;
        private Button btnClear;
    }
}
