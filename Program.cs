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
            AppController controller = new AppController(view, model);         
            
            controller.Execute();
                                   
        } 
             
                   
                  

    }



}