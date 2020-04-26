using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class wndRomanCalculator : Form
    {
        private int FirstNumber;
        private int SecondNumber;
        private string Operand;
        private bool IsCalculated;

        public wndRomanCalculator()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string strInput = txtOutput.Text;

            string strOutput;
            if (strInput.Length == 0)
            {
                strOutput = "0";
            }
            else if (strInput.Length == 1)
            {
                strOutput = GetRomanValue(strInput[0]).ToString();
            }
            else
            {
                strOutput = ConvertStringToInteger(strInput).ToString();
            }
            if (ConvertIntegerToRoman(ConvertStringToInteger(strInput)) != strInput || strOutput == "0")
            {
                DisplayError();
            }

            if (strOutput != "0")
            {
                txtOutput.Text = strOutput;
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

        private void DisplayError()
        {
            IsCalculated = true;
            Display(true);
            txtOutput.Text = "Error";
        }

        private int ConvertStringToInteger(string strInput)
        {
            int returnInt = 0;
            char[] Input = strInput.ToCharArray();
            for (int i = 0; i < Input.Length; i++)
            {
                if (i == 0)
                {
                    returnInt = GetRomanValue(Input[i]);
                }
                else
                {
                    try
                    {
                        returnInt += GetRomanValue(Input[i], Input[i - 1]);
                    }
                    catch (InvalidInputException)
                    {
                        txtCalculation.Text = strInput;
                        DisplayError();
                        returnInt = 0;
                    }
                }
            }
            return returnInt;
        }

        private int GetRomanValue(char charCurrent)
        {
            int intResult;
            switch (charCurrent)
            {
                case ('I'):
                    intResult = 1;
                    break;
                case ('V'):
                    intResult = 5;
                    break;
                case ('X'):
                    intResult = 10;
                    break;
                case ('L'):
                    intResult = 50;
                    break;
                case ('C'):
                    intResult = 100;
                    break;
                case ('D'):
                    intResult = 500;
                    break;
                case ('M'):
                    intResult = 1000;
                    break;
                default:
                    intResult = 0;
                    break;
            }
            return intResult;
        }

        private int GetRomanValue(char charCurrent, char charPrevious)
        {
            int intResult;
            switch (charCurrent)
            {
                case ('I'):
                    intResult = 1;
                    break;
                case ('V'):
                    if (charPrevious == 'I')
                    {
                        intResult = 3;
                    }
                    else if (charPrevious == 'X' || charPrevious == 'L' || charPrevious == 'C' || charPrevious == 'D' || charPrevious == 'M')
                    {
                        intResult = 5;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                case ('X'):
                    if (charPrevious == 'I')
                    {
                        intResult = 8;
                    }
                    else if (charPrevious == 'X' || charPrevious == 'L' || charPrevious == 'C' || charPrevious == 'D' || charPrevious == 'M')
                    {
                        intResult = 10;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                case ('L'):
                    if (charPrevious == 'X')
                    {
                        intResult = 30;
                    }
                    else if (charPrevious == 'C' || charPrevious == 'D' || charPrevious == 'M')
                    {
                        intResult = 50;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                case ('C'):
                    if (charPrevious == 'X')
                    {
                        intResult = 80;
                    }
                    else if (charPrevious == 'C' || charPrevious == 'D' || charPrevious == 'M')
                    {
                        intResult = 100;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                case ('D'):
                    if (charPrevious == 'C')
                    {
                        intResult = 300;
                    }
                    else if (charPrevious == 'M')
                    {
                        intResult = 500;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                case ('M'):
                    if (charPrevious == 'C')
                    {
                        intResult = 800;
                    }
                    else if (charPrevious == 'M')
                    {
                        intResult = 1000;
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                    break;
                default:
                    intResult = 0;
                    break;
            }
            return intResult;
        }
        private string ConvertIntegerToRoman(int input)
        {
            bool isNegative = false;
            if (input < 0)
            {
                isNegative = true;
                input *= -1;
            }

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string output = "";
            foreach (int value in values)
            {
                string text = "";
                switch (value)
                {
                    case 1000:
                        text = "M";
                        break;
                    case 900:
                        text = "CM";
                        break;
                    case 500:
                        text = "D";
                        break;
                    case 400:
                        text = "CD";
                        break;
                    case 100:
                        text = "C";
                        break;
                    case 90:
                        text = "XC";
                        break;
                    case 50:
                        text = "L";
                        break;
                    case 40:
                        text = "XL";
                        break;
                    case 10:
                        text = "X";
                        break;
                    case 9:
                        text = "IX";
                        break;
                    case 5:
                        text = "V";
                        break;
                    case 4:
                        text = "IV";
                        break;
                    case 1:
                        text = "I";
                        break;
                }
                int amount = input / value;
                for (int i = 0; i < amount; i++)
                {
                    output += text;
                    input -= value;
                }
            }

            if (isNegative)
            { 
                output = "-" + output;
            }

            return output;
        }

        private void BtnGo2_Click(object sender, EventArgs e)
        {
            //tbOutput2.Text = ConvertIntegerToRoman(int.Parse(tbInput2.Text));
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                Display(false);
                IsCalculated = false;
                txtOutput.Text = "";
                Operand = "";
                txtCalculation.Text = "";
            }
            string buttonText = ((Button)sender).Text;
            txtOutput.Text += buttonText;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            IsCalculated = false;
            FirstNumber = ConvertStringToInteger(txtOutput.Text);

            if (FirstNumber == 0)
            {
                return;
            }
            
            Operand = ((Button)sender).Tag.ToString();
            Display(false);
            txtCalculation.Text = txtOutput.Text + " " + ((Button)sender).Text;
            txtOutput.Text = "";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            string outputText = txtOutput.Text;
            string calculationText = txtCalculation.Text;
            SecondNumber = ConvertStringToInteger(outputText);

            if (SecondNumber == 0)
            {
                txtCalculation.Text = calculationText + " " + outputText + " = ";
                DisplayError();
                return;
            }

            Display(false);
            txtCalculation.Text = calculationText + " " + outputText + " = ";
            string calculation = FirstNumber.ToString() + Operand + SecondNumber.ToString();
            DataTable dt = new DataTable();
            string result = dt.Compute(calculation, null).ToString();
            txtOutput.Text = ConvertIntegerToRoman(int.Parse(result));
            IsCalculated = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FirstNumber = 0;
            SecondNumber = 0;
            txtOutput.Text = "";
            txtCalculation.Text = "";
            Operand = "";
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
    }
}