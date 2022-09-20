using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tutorial
{
    class CalculatorModel
    {
        public double Calculate(double firstNumberD, double secondNumberD, string enterOperator)
        {
            double result = 0;
            switch (enterOperator)
            {
                case "+":
                    result = AddWithSum(firstNumberD, secondNumberD);
                    break;

                case "-":
                    result = SubtractNumbers(firstNumberD, secondNumberD);
                    break;

                case "*":
                    result = MultiplicateNumbers(firstNumberD, secondNumberD);
                    break;

                case "/":
                    result = DivideNumbers(firstNumberD, secondNumberD);
                    break;


            }

            return result;

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
