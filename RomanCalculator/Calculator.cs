using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    class Calculator
    {
        private int firstNumber;
        private int secondNumber;
        private string operand;

        public void SetOperand(string operandIn)
        {
            operand = operandIn;
        }
        public string GetOperand()
        {
            return operand;
        }
        public void SetFirstNumber(int firstNumberIn)
        {
            firstNumber = firstNumberIn;
        }
        public int GetFirstNumber()
        {
            return firstNumber;
        }
        public void SetSecondNumber(int secondNumberIn)
        {
            secondNumber = secondNumberIn;
        }
        public int GetSecondNumber()
        {
            return secondNumber;
        }
        public string Calculate()
        {
            string calculation = firstNumber.ToString() + operand + secondNumber.ToString();
            System.Data.DataTable dt = new System.Data.DataTable();
            string result = dt.Compute(calculation, null).ToString();
            return RomanNumbers.ConvertIntegerToRoman(int.Parse(result));
        }
        public void Clear()
        {
            firstNumber = 0;
            secondNumber = 0;
            operand = "";
        }
    }
}
