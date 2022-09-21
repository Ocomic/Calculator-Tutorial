using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tutorial
{
    class CalculatorModel
    {
        public double Result { get; private set; }
        public string EnterOperator { get; set; }
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }


        public CalculatorModel()
        {
            Result = 0;
            EnterOperator = "unknown";
        }
        public void Calculate()
        {
            switch (EnterOperator)
            {
                case "+":
                    Result = AddWithSum(FirstNumber, SecondNumber);
                    break;

                case "-":
                    Result = SubtractNumbers(FirstNumber, SecondNumber);
                    break;

                case "*":
                    Result = MultiplicateNumbers(FirstNumber, SecondNumber);
                    break;

                case "/":
                    Result = DivideNumbers(FirstNumber, SecondNumber);
                    break;


            }

           

        }

        private double AddWithSum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        private double SubtractNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        private double MultiplicateNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        private double DivideNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
