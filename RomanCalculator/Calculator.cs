using System;

namespace RomanCalculator
{
    class Calculator
    {
        public int FirstNumber { get; set; }
        public int Memory { get; set; }
        public string Operand { get; set; }
        public int SecondNumber { get; set; }

        public string Calculate()
        {
            string calculation = FirstNumber.ToString() + Operand + SecondNumber.ToString();
            System.Data.DataTable dt = new System.Data.DataTable();
            string result = dt.Compute(calculation, null).ToString();
            if(result == "0")
            {
                return "0";
            }
            else
            {
                return RomanNumbers.ConvertIntegerToRoman(int.Parse(result));
            }            
        }

        public void Clear()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            Operand = "";
        }

        public string SquareRoot(string input)
        {
            double dblInput = RomanNumbers.ConvertRomanToInteger(input,false);
            int Result = Convert.ToInt32(Math.Round(Math.Sqrt(dblInput)));
            return RomanNumbers.ConvertIntegerToRoman(Result);
        }

    }
}