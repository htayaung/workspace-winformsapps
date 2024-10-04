namespace SimpleCalculator
{
    public partial class FrmMain : Form
    {
        #region Members

        private double firstNumber;

        private double secondNumber;
        private double result
        {
            get
            {
                if (double.TryParse(txtResult.Text, out double value))
                {
                    return value;
                }
                else
                {
                    return default;
                }
            }
            set
            {
                txtResult.Text = value.ToString();
            }
        }

        private OperatorType selectedOperator;

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Control Events

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetOperatorType(OperatorType.Plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetOperatorType(OperatorType.Minus);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperatorType(OperatorType.Multiply);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            SetOperatorType(OperatorType.Division);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            SetInputValue("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            SetInputValue("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            SetInputValue("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            SetInputValue("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            SetInputValue("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            SetInputValue("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            SetInputValue("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            SetInputValue("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            SetInputValue("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            SetInputValue("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNumber = default;
            secondNumber = default;
            result = default;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = result;

                switch (selectedOperator)
                {
                    case OperatorType.Plus:
                        result = firstNumber + secondNumber;
                        break;
                    case OperatorType.Minus:
                        result = firstNumber - secondNumber;
                        break;
                    case OperatorType.Multiply:
                        result = firstNumber * secondNumber;
                        break;
                    case OperatorType.Division:
                        if (secondNumber == 0)
                        {
                            ShowErrorMessage("Division by zero.");
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                ShowErrorMessage("An error has occurred.");
            }
        }

        #endregion

        #region Private Methods

        private void SetInputValue(string input)
        {
            if (result == 0)
            {
                result = double.Parse(input);
            }
            else
            {
                result = double.Parse($"{result}{input}");
            }
        }

        private void SetOperatorType(OperatorType type)
        {
            selectedOperator = type;
            firstNumber = result;
            result = default;
        }

        private void ShowErrorMessage(string text, string title = "Error")
        {
            MessageBox.Show(text,
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        #endregion
    }

    public enum OperatorType
    {
        Plus = 0,
        Minus = 1,
        Multiply = 2,
        Division = 3,
    }
}
