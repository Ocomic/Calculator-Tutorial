using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tutorial
{
    internal class ConsoleView
    {
        private CalculatorModel model;
        public ConsoleView(CalculatorModel model)
        {
            this.model = model;
            UserEndProgram = false;
        }

        public bool UserEndProgram { get; private set; }

        public void GetFirstUserInput()
        {
            model.FirstNumber = GetUserNumber();
            model.EnterOperator = GetUserOperator();
            model.SecondNumber = GetUserNumber();
        }

        public void GetUserInputForCalculation()
        {
            string input = GetNextUserAction();

            if (input == "Close")
            {
                UserEndProgram = true;
            }
            else
            {
                model.FirstNumber = model.Result;
                model.SecondNumber = Convert.ToDouble(input);
            }
        }

        private string GetNextUserAction()
        {
            Console.Write("Please enter a number or type Close to End program: ");
            return Console.ReadLine();
        }
        private double GetUserNumber()
        {
            string input;
            Console.Write("Please enter a number: "); 
            input = Console.ReadLine();

            return Convert.ToDouble(input);
        }

        private string GetUserOperator()
        {

            Console.Write("Please enter an operator (+, -, *, /: ");
            return Console.ReadLine();
        }

        public void ResultOutput()
        {
            switch (model.EnterOperator)
            {

                case "+":
                    Console.WriteLine("The result of the addition is: {0}", model.Result);
                    break;

                case "-":
                    Console.WriteLine("The result of the subtraction is: {0}", model.Result);
                    break;

                case "*":
                    Console.WriteLine("The result of the multiplication is: {0}", model.Result);
                    break;

                case "/":
                    Console.WriteLine("The result of the division is: {0}", model.Result);
                    break;

                default:
                    Console.WriteLine("Invalid Input of operator");
                    break;

            }
        }


    }
}
