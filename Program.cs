using Calculator_Tutorial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Udemy course: https://www.udemy.com/course/einstieg-in-csharp-software-programmieren-wie-ein-profi/learn/lecture/4126070#overview
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            CalculatorModel model = new CalculatorModel();
            ConsoleView view = new ConsoleView(model);

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