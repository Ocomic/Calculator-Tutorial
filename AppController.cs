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
            double firstNumber = view.GetUserNumber();
            string enterOperator = view.GetUserOperator();
            double secondNumber = view.GetUserNumber();
                               

            // calculates result of two numbers with different cases of operations

            model.Calculate(firstNumber, secondNumber, enterOperator);

            // ConsoleView - Output
            view.ResultOutput();
            view.WaitForUserClose();
        }
    }
}
