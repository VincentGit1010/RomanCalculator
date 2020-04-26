using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    class RomanNumbers
    {
        public static int ConvertStringToInteger(string strInput)
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
                    returnInt += GetRomanValue(Input[i], Input[i - 1]);
                }
            }
            if(RomanNumbers.ConvertIntegerToRoman(returnInt) != strInput)
            {
                throw new InvalidInputException();
            }
            else
            {
                return returnInt;
            }            
        }
        public static int GetRomanValue(char charCurrent)
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
        public static int GetRomanValue(char charCurrent, char charPrevious)
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
                    else
                    {
                        intResult = 5;
                    }
                    break;
                case ('X'):
                    if (charPrevious == 'I')
                    {
                        intResult = 8;
                    }
                    else
                    {
                        intResult = 10;
                    }                    
                    break;
                case ('L'):
                    if (charPrevious == 'X')
                    {
                        intResult = 30;
                    }
                    else
                    {
                        intResult = 50;
                    }
                    break;
                case ('C'):
                    if (charPrevious == 'X')
                    {
                        intResult = 80;
                    }
                    else
                    {
                        intResult = 100;
                    }
                    break;
                case ('D'):
                    if (charPrevious == 'C')
                    {
                        intResult = 300;
                    }
                    else
                    {
                        intResult = 500;
                    }
                    break;
                case ('M'):
                    if (charPrevious == 'C')
                    {
                        intResult = 800;
                    }
                    else
                    {
                        intResult = 1000;
                    }
                    break;
                default:
                    intResult = 0;
                    break;
            }
            return intResult;
        }
        public static string ConvertIntegerToRoman(int input)
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
    }
}
