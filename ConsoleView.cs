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
        }
        public string GetUserNumber()
        {

            Console.Write("Please enter a number: ");           
            return Console.ReadLine();
        }

        public string GetUserOperator()
        {

            Console.Write("Please enter an operator (+, -, *, /: ");
            return Console.ReadLine();
        }

        public string WaitForUserClose()
        {

            Console.Write("Press Return to end program.");
            return Console.ReadLine();
        }

        public void ResultOutput(string enterOperator)
        {
            switch (enterOperator)
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
