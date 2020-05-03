using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class WndRomanCalculator : Form
    {
        private bool isCalculated, unfolded;
        private readonly Calculator calculator = new Calculator();
        public string GoodString { get; set; }

        public WndRomanCalculator()
        {
            InitializeComponent();
        }

        private void WndRomanCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            string buttonPressed = "btn" + e.KeyChar.ToString().ToUpper();

            switch (e.KeyChar)
            {
                case '+':
                    buttonPressed = "btnPlus";
                    break;
                case '-':
                    buttonPressed = "btnMin";
                    break;
                case '/':
                    buttonPressed = "btnDivide";
                    break;
                case '*':
                    buttonPressed = "btnMultiply";
                    break;
                case '=':
                    buttonPressed = "btnEquals";
                    break;
                case '\b':
                    buttonPressed = "btnBackspace";
                    break;
            }
            Button button = Controls.OfType<Button>()
                                    .FirstOrDefault(x => x.Name == buttonPressed);

            switch (button.Name)
            {
                case "btnI":
                case "btnV":
                case "btnX":
                case "btnL":
                case "btnC":
                case "btnD":
                case "btnM":
                    BtnNumber_Click(button, null);
                    break;
                case "btnPlus":
                case "btnMin":
                case "btnMultiply":
                case "btnDivide":
                    BtnOperand_Click(button, null);
                    break;
                case "btnSquare":
                case "btnReciprocal":
                case "btnRoot":
                case "btnProcent":
                    BtnFunction_Click(button, null);
                    break;
                case "btnEquals":
                    BtnEquals_Click(button, null);
                    break;
                case "btnBackspace":
                    BtnBackspace_Click(button, null);
                    break;
            }
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
        }

        private void DisplayError(string badText, string goodText)
        {
            wndException dialogForm = new wndException
            {
                BadText = badText,
                GoodText = goodText
            };

            dialogForm.ShowDialog(this);
            isCalculated = false;
            Display(true);
            txtOutput.Text = "Error";
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (isCalculated || txtOutput.Text == "Error")
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
            isCalculated = false;
            string calculationText;
            if (txtOutput.Text != "" || txtCalculation.Text == "")
            {
                try
                {
                    calculator.FirstNumber = RomanNumbers.ConvertRomanToInteger(txtOutput.Text, false);
                    calculationText = txtOutput.Text + " " + ((Button)sender).Text;
                }
                catch (InvalidInputException)
                {
                    calculator.FirstNumber = 0;
                    DisplayError(txtOutput.Text, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(txtOutput.Text, true)));
                    return;
                }
                if (calculator.FirstNumber == 0)
                {
                    return;
                }
            }
            else
            {
                txtCalculation.Text = txtCalculation.Text.Substring(0, txtCalculation.Text.Length - 1);
                calculationText = txtCalculation.Text + ((Button)sender).Text;
            }

            calculator.Operand = (((Button)sender).Tag.ToString());
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
                if (calculator.SecondNumber == 0)
                {
                    calculator.SecondNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                }
            }
            catch (InvalidInputException)
            {
                DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                return;
            }
            if (calculator.SecondNumber == 0)
            {
                txtCalculation.Text = calculationText + " " + outputText + " = ";
                DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                return;
            }
            if (isCalculated)
            {
                calculator.FirstNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                txtCalculation.Text = outputText + " " + calculator.Operand + " " + RomanNumbers.ConvertIntegerToRoman(calculator.SecondNumber);
                txtOutput.Text = calculator.Calculate();
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
            calculator.Memory += RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString(), false);
            EnableMemFunctions(true);
        }

        private void BtnMemMin_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                return;
            }
            calculator.Memory -= RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString(), false);
            EnableMemFunctions(true);
        }

        private void BtnMemStore_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                return;
            }
            calculator.Memory = RomanNumbers.ConvertRomanToInteger(txtOutput.Text.ToString(), false);
            EnableMemFunctions(true);
        }

        private void BtnMemShow_Click(object sender, EventArgs e)
        {
            if (unfolded)
            {
                lblMem.Visible = false;
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
            }
            else
            {
                lblMem.Visible = true;
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

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            if (txtCalculation.Text == "")
            {
                try
                {
                    calculator.FirstNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                }
                catch (InvalidInputException)
                {
                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }
                Display(false);
                txtCalculation.Text = "\u221A" + outputText;
                txtOutput.Text = calculator.SquareRoot(outputText);
                isCalculated = true;
            }
            else
            {
                txtCalculation.Text += "\u221A" + outputText;
                try
                {
                    calculator.SecondNumber = RomanNumbers.ConvertRomanToInteger(calculator.SquareRoot(outputText), false);
                    txtOutput.Text = calculator.Calculate();
                }
                catch (InvalidInputException)
                {

                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }

            }

        }

        private void BtnReciprocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1\\x is nog niet ingebouwd.");
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            if (txtCalculation.Text == "")
            {
                try
                {
                    calculator.FirstNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                }
                catch (InvalidInputException)
                {
                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }
                Display(false);
                txtCalculation.Text = outputText + "\u00B2";
                txtOutput.Text = calculator.Square(outputText);
                isCalculated = true;
            }
            else
            {
                txtCalculation.Text += outputText + "\u00B2";
                try
                {
                    calculator.SecondNumber = RomanNumbers.ConvertRomanToInteger(calculator.Square(outputText), false);
                    txtOutput.Text = calculator.Calculate();
                }
                catch (InvalidInputException)
                {
                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }
            }
        }

        private void BtnProcent_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            double dblResult;
            if (txtCalculation.Text == "")
            {
                try
                {
                    calculator.FirstNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                }
                catch (InvalidInputException)
                {
                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }
                Display(false);
                txtCalculation.Text = outputText + "%";
                dblResult = Math.Round(Convert.ToDouble(calculator.FirstNumber) / 100);
                txtOutput.Text = RomanNumbers.ConvertIntegerToRoman(Convert.ToInt32(dblResult));
                isCalculated = true;
            }
            else
            {
                txtCalculation.Text += outputText + "%";
                try
                {
                    calculator.SecondNumber = RomanNumbers.ConvertRomanToInteger(outputText, false);
                    double dblSecondnumber = Math.Round(Convert.ToDouble(calculator.SecondNumber) / 100);
                    calculator.SecondNumber = Convert.ToInt32(dblSecondnumber);
                    txtOutput.Text = calculator.Calculate();
                    isCalculated = true;
                }
                catch (InvalidInputException)
                {
                    DisplayError(outputText, RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(outputText, true)));
                    return;
                }
            }
        }

        private void BtnNegate_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                txtOutput.Text = RomanNumbers.ConvertIntegerToRoman(RomanNumbers.ConvertRomanToInteger(txtOutput.Text, false) * -1);
            }
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

