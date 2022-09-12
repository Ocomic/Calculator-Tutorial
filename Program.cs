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

            // User Story: As a user I want to have a function that can do a calculation
            // first Iteration is to implement addition (+) of two or more numbers (make a SUM)

            Console.Write("Please enter first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Please enter second number: ");
            string secondNumber = Console.ReadLine();

            // convert string to int for calculation
            double firstNumberD = Convert.ToDouble(firstNumber);
            double secondNumberD = Convert.ToDouble(secondNumber);

            // calculates sum of two numbers
            double sum = AddWithSum(firstNumberD, secondNumberD);

            // return value of calculation in Console
            Console.WriteLine("The solution is: {0}", sum);
            WaitForUserInput();
                     

           
        }

        static double AddWithSum(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        static void WaitForUserInput()
        {
            Console.Write("Press return to quit.");
            Console.ReadLine();
        }


    }



}