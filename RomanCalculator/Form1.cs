using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class WndRomanCalculator : Form
    {
        private bool IsCalculated;
        private readonly Calculator calculator = new Calculator();
        private static readonly string[] numbers = { "I", "V", "X", "L", "C", "D", "M" };
        private static readonly string[] operands = { "+", "-", "*", "/" };
        public WndRomanCalculator()
        {
            InitializeComponent();
            txtOutput.Focus();
        }
        private void Display(bool isError)
        {
            if (isError)
            {
                txtCalculation.ForeColor = Color.Red;
            }
            else
            {
                txtCalculation.ForeColor = Color.Black;
            }
            txtOutput.Focus();
        }

        private void DisplayError()
        {
            IsCalculated = true;
            Display(true);
            txtOutput.Text = "Error";
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                Display(false);
                IsCalculated = false;
                txtOutput.Text = "";
                calculator.SetOperand("");
                txtCalculation.Text = "";
            }
            string buttonText = ((Button)sender).Text;
            txtOutput.Text += buttonText;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            IsCalculated = false;
            string calculationText;
            if(txtOutput.Text != "" || txtCalculation.Text == "")
            {
                try
                {
                    calculator.SetFirstNumber(RomanNumbers.ConvertStringToInteger(txtOutput.Text));
                    calculationText = txtOutput.Text + " " + ((Button)sender).Text;
                }
                catch (InvalidInputException)
                {
                    calculator.SetFirstNumber(0);
                    DisplayError();
                    return;
                }
                if (calculator.GetFirstNumber() == 0)
                {
                    return;
                }
            } else
            {
                txtCalculation.Text = txtCalculation.Text.Substring(0, txtCalculation.Text.Length - 1);
                calculationText = txtCalculation.Text + ((Button)sender).Text;
            }           
            
            calculator.SetOperand(((Button)sender).Tag.ToString());
            Display(false);
            txtCalculation.Text = calculationText;
            txtOutput.Text = "";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            string calculationText = txtCalculation.Text;
            try
            {
                calculator.SetSecondNumber(RomanNumbers.ConvertStringToInteger(outputText));
            }
            catch (InvalidInputException)
            {
                DisplayError();
                return;
            }
            if (calculator.GetSecondNumber() == 0)
            {
                txtCalculation.Text = calculationText + " " + outputText + " = ";
                DisplayError();
                return;
            }

            Display(false);
            txtCalculation.Text = calculationText + " " + outputText + " = ";
            txtOutput.Text = calculator.Calculate();
            IsCalculated = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtOutput.Text = "";
            txtCalculation.Text = "";
            IsCalculated = false;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            if (!IsCalculated)
            {
                txtOutput.Text = "";
            }
        }

        private void TxtBackspace_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            int textLength = outputText.Length;
            if (textLength > 0 && !IsCalculated)
            {
                txtOutput.Text = outputText.Substring(0, textLength - 1);
            }
        }

        private void TxtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string buttonTag = e.KeyChar.ToString().ToUpper();
            if (buttonTag == "\b")
            {
                buttonTag = "BS";
            }
            foreach (var control in this.Controls)
            {
                if (control.GetType() != typeof(Button))
                {
                    continue;
                }
                Button buttonPressed = ((Button)control);
                if (buttonPressed.Tag.ToString() == buttonTag)
                {
                    if (numbers.Contains(buttonTag))
                    {
                        BtnNumber_Click(buttonPressed, null);
                        break;
                    }
                    else if (operands.Contains(buttonTag))
                    {
                        BtnCalculate_Click(buttonPressed, null);
                    }
                    else if (buttonTag == "=")
                    {
                        BtnEquals_Click(buttonPressed, null);
                    }
                    else if (buttonTag == "BS")
                    {
                        TxtBackspace_Click(buttonPressed, null);
                    }
                }
            }
        }
    }
}