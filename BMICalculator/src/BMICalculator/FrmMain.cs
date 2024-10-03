using BMICalculator.Models;
using System.Drawing.Drawing2D;

namespace BMICalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Control Events

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Control visiblity
            SetControlVisibility();

            // Bind controls
            BindControls();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetWeight(out double weight))
                {
                    ShowErrorMessage("Enter valid weight in lbs/kg.");
                }

                if (!TryGetHeight(out double height))
                {
                    ShowErrorMessage("Enter valid height in cm/in.");
                }

                double bmi = CalculateBMI(weight, height);
                lblResult.Text = $"Your Body Mass Index is {bmi:F2}";
                SetClassification(bmi);

                pnlResult.Visible = true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage("An error has occurred while calculating BMI.");
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        private void cboWeightUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        private void cboHeightInFeet_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        private void cboHeightInInch_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        private void cboHeightUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideResultPanel();
        }

        #endregion

        #region Private Methods

        private void SetControlVisibility()
        {
            pnlResult.Visible = false;
        }

        private void BindControls()
        {
            BindBodyWeightUnit();
            BindBodyHeight();
            BindBodyHeightUnit();
        }

        private void BindBodyWeightUnit()
        {
            var items = new List<ListItem<string>>
            {
                new ListItem<string>{ Value = "lbs", Description = "lbs" },
                new ListItem<string>{ Value = "kg", Description = "kg" },
            };

            cboWeightUnit.DataSource = items;
            cboWeightUnit.ValueMember = "Value";
            cboWeightUnit.DisplayMember = "Description";
        }

        private void BindBodyHeight()
        {
            var heightInFeets = new List<ListItem<int>>
            {
                new ListItem<int>(),
                new ListItem<int>{ Value = 4, Description = "4'" },
                new ListItem<int>{ Value = 5, Description = "5'" },
                new ListItem<int>{ Value = 6, Description = "6'" },
                new ListItem<int>{ Value = 7, Description = "7'" },
            };

            cboHeightInFeet.DataSource = heightInFeets;
            cboHeightInFeet.ValueMember = "Value";
            cboHeightInFeet.DisplayMember = "Description";

            var heightInInches = new List<ListItem<int>>
            {
                new ListItem<int>(),
                new ListItem<int>{ Value = 0, Description = "0\"" },
                new ListItem<int>{ Value = 1, Description = "1\"" },
                new ListItem<int>{ Value = 2, Description = "2\"" },
                new ListItem<int>{ Value = 3, Description = "3\"" },
                new ListItem<int>{ Value = 4, Description = "4\"" },
                new ListItem<int>{ Value = 5, Description = "5\"" },
                new ListItem<int>{ Value = 6, Description = "6\"" },
                new ListItem<int>{ Value = 7, Description = "7\"" },
                new ListItem<int>{ Value = 8, Description = "8\"" },
                new ListItem<int>{ Value = 9, Description = "9\"" },
                new ListItem<int>{ Value = 10, Description = "10\"" },
                new ListItem<int>{ Value = 11, Description = "11\"" },
                new ListItem<int>{ Value = 12, Description = "12\"" },
            };

            cboHeightInInch.DataSource = heightInInches;
            cboHeightInInch.ValueMember = "Value";
            cboHeightInInch.DisplayMember = "Description";
        }

        private void BindBodyHeightUnit()
        {
            var items = new List<ListItem<string>>
            {
                new ListItem<string>{ Value = "cm", Description = "cm" },
                new ListItem<string>{ Value = "in.", Description = "in." },
            };

            cboHeightUnit.DataSource = items;
            cboHeightUnit.ValueMember = "Value";
            cboHeightUnit.DisplayMember = "Description";
        }

        private bool TryGetWeight(out double weight)
        {
            weight = default;
            if (double.TryParse(txtWeight.Text, out double output))
            {
                if (string.Equals(cboWeightUnit.SelectedValue?.ToString(), "kg", StringComparison.OrdinalIgnoreCase))
                {
                    weight = output;
                }
                else
                {
                    weight = output / 2.205;
                }

                return true;
            }

            return false;
        }

        private bool TryGetHeight(out double height)
        {
            height = default;
            bool isValid = true;

            if (cboHeightInFeet.SelectedIndex > 0 ||
                cboHeightInInch.SelectedIndex > 0)
            {
                double.TryParse(cboHeightInFeet.SelectedValue?.ToString(), out double heightInFeet);
                double.TryParse(cboHeightInInch.SelectedValue?.ToString(), out double heightInInch);

                height = (heightInFeet * 0.3048) + (heightInInch * 0.0254);
            }
            else
            {
                // handle user input for cm/in
                if (double.TryParse(txtHeight.Text, out double output))
                {
                    if (string.Equals(cboHeightUnit.SelectedValue?.ToString(), "cm", StringComparison.OrdinalIgnoreCase))
                    {
                        height = output / 100;
                    }
                    else
                    {
                        height = output / 39.37;
                    }
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private double CalculateBMI(double weight, double height)
        {
            // BMI = kg / m2

            return weight / (height * height);
        }

        private void SetClassification(double bmi)
        {
            string classType = string.Empty;
            string riskType = string.Empty;
            string riskLevelColor = string.Empty;

            if (bmi < 18.5)
            {
                classType = "Underweight";
                riskType = "Increased";
                riskLevelColor = "Red";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                classType = "Normal Weight";
                riskType = "Least";
                riskLevelColor = "Green";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                classType = "Overweight";
                riskType = "Increased";
                riskLevelColor = "Orange";
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                classType = "Obese class I";
                riskType = "High";
                riskLevelColor = "Red";
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                classType = "Obese class II";
                riskType = "Very high";
                riskLevelColor = "Red";
            }
            else
            {
                classType = "Obese class III";
                riskType = "Extremely high";
                riskLevelColor = "Red";
            }

            lblClassificationResult.Text = classType;
            lblRiskTypeResult.Text = riskType;
            lblRiskTypeResult.BackColor = Color.FromName(riskLevelColor);
        }

        private void ShowErrorMessage(string text, string title = "Error")
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HideResultPanel()
        {
            pnlResult.Visible = false;
        }

        #endregion
    }
}
