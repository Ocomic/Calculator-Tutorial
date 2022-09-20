using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tutorial
{
    internal class AppController
    {
        private ConsoleView view;
        private CalculatorModel model;

        public AppController(ConsoleView view, CalculatorModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Execute()
        {
            string firstNumber = view.GetUserNumber();
            string enterOperator = view.GetUserOperator();
            string secondNumber = view.GetUserNumber();

            // convert string to int for calculation
            // TODO: create new method when code gets bigger.
            double firstNumberD = Convert.ToDouble(firstNumber);
            double secondNumberD = Convert.ToDouble(secondNumber);


            // calculates result of two numbers with different cases of operations

            model.Calculate(firstNumberD, secondNumberD, enterOperator);

            // ConsoleView - Output
            view.ResultOutput(enterOperator);
            view.WaitForUserClose();
        }
    }
}
