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
        public string EnterOperator { get; private set; }
        public CalculatorModel()
        {
            Result = 0;
            EnterOperator = "unknown";
        }
        public void Calculate(double firstNumberD, double secondNumberD, string enterOperator)
        {
            this.EnterOperator = enterOperator;

            switch (enterOperator)
            {
                case "+":
                    Result = AddWithSum(firstNumberD, secondNumberD);
                    break;

                case "-":
                    Result = SubtractNumbers(firstNumberD, secondNumberD);
                    break;

                case "*":
                    Result = MultiplicateNumbers(firstNumberD, secondNumberD);
                    break;

                case "/":
                    Result = DivideNumbers(firstNumberD, secondNumberD);
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
