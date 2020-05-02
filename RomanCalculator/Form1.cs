using System;
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
            KeyPreview = true;
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
            isCalculated = true;
            Display(true);
            txtOutput.Text = "Error";
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                Display(false);
                isCalculated = false;
                txtOutput.Text = "";
                calculator.Operand = "";
                txtCalculation.Text = "";
            }
            string buttonText = ((Button)sender).Text;
            txtOutput.Text += buttonText;
        }

        private void BtnOperand_Click(object sender, EventArgs e)
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

        private void BtnFunction_Click(object sender, EventArgs e)
        {
            string button = ((Button)sender).Name;

            switch (button)
            {
                case "btnSquare":
                    break;
                case "btnReciprocal":
                    break;
                case "btnRoot":
                    break;
                case "btnProcent":
                    break;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            string calculationText = txtCalculation.Text;
            try
            {
                calculator.SecondNumber = RomanNumbers.ConvertRomanToInteger(outputText);
            }
            catch (InvalidInputException)
            {
                DisplayError();
                return;
            }
            if (calculator.SecondNumber == 0)
            {
                txtCalculation.Text = calculationText + " " + outputText + " = ";
                DisplayError();
                return;
            }

            Display(false);
            txtCalculation.Text = calculationText + " " + outputText + " = ";
            txtOutput.Text = calculator.Calculate();
            isCalculated = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtOutput.Text = "";
            txtCalculation.Text = "";
            isCalculated = false;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
            {
                txtOutput.Text = "";
            }
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            int textLength = outputText.Length;
            if (textLength > 0 && !isCalculated)
            {
                txtOutput.Text = outputText.Substring(0, textLength - 1);
            }
        }

        private void BtnMemClear_Click(object sender, EventArgs e)
        {
            EnableMemFunctions(false);
            calculator.Memory = 0;
        }

        private void BtnMemRecall_Click(object sender, EventArgs e)
        {
            txtOutput.Text = RomanNumbers.ConvertIntegerToRoman(calculator.Memory);
            if (calculator.FirstNumber == 0)
            {
                calculator.FirstNumber = calculator.Memory;
            }
            else
            {
                calculator.SecondNumber = calculator.Memory;
            }
        }

        private void BtnMemPlus_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                return;
            }
            calculator.Memory += RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString());
            EnableMemFunctions(true);
        }

        private void BtnMemMin_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                return;
            }
            calculator.Memory -= RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString());
            EnableMemFunctions(true);
        }

        private void BtnMemStore_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                return;
            }
            calculator.Memory = RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString());
            EnableMemFunctions(true);
        }

        private void BtnMemShow_Click(object sender, EventArgs e)
        {
            if (unfolded)
            {
                lblMem.BackColor = SystemColors.Control;
                this.BackColor = SystemColors.Control;
                txtOutput.BackColor = SystemColors.Control;
                txtCalculation.BackColor = SystemColors.Control;
                btnMemClear.BackColor = SystemColors.Control;
                btnMemMin.BackColor = SystemColors.Control;
                btnMemPlus.BackColor = SystemColors.Control;
                btnMemRecall.BackColor = SystemColors.Control;
                btnMemShow.BackColor = SystemColors.Control;
                btnMemStore.BackColor = SystemColors.Control;
                lblMem.Left = 3;
                lblMem.Top = 77;
                lblMem.Width = 34;
                lblMem.Height = 13;
                lblMem.SendToBack();
                lblMem.Text = "";
                unfolded = false;
            }
            else
            {
                lblMem.BackColor = SystemColors.ScrollBar;
                this.BackColor = SystemColors.ControlDark;
                txtOutput.BackColor = SystemColors.ControlDark;
                txtCalculation.BackColor = SystemColors.ControlDark;
                btnMemClear.BackColor = SystemColors.ControlDark;
                btnMemMin.BackColor = SystemColors.ControlDark;
                btnMemPlus.BackColor = SystemColors.ControlDark;
                btnMemRecall.BackColor = SystemColors.ControlDark;
                btnMemShow.BackColor = SystemColors.ControlDark;
                btnMemStore.BackColor = SystemColors.ControlDark;
                lblMem.Left = 6;
                lblMem.Top = 128;
                lblMem.Width = 340;
                lblMem.Height = 313;
                lblMem.BringToFront();
                lblMem.Text = RomanNumbers.ConvertIntegerToRoman(calculator.Memory);
                unfolded = true;
            }
            Refresh();
        }

        private void EnableMemFunctions(bool enable)
        {
            if (enable == true)
            {
                btnMemClear.Enabled = true;
                btnMemMin.Enabled = true;
                btnMemPlus.Enabled = true;
                btnMemRecall.Enabled = true;
                btnMemShow.Enabled = true;
            }
            else
            {
                btnMemClear.Enabled = false;
                btnMemRecall.Enabled = false;
                btnMemShow.Enabled = false;
            }
        }
    }
}
