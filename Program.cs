﻿using Calculator_Tutorial;
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

            string firstNumber = GetUserInput("Please enter the first number: ");
            string secondNumber = GetUserInput("Please enter the second number: ");
            string enterOperator = GetUserInput("please enter an operator (+, -, * or /): ");

            // convert string to int for calculation
            // TODO: create new method when code gets bigger.
            double firstNumberD = Convert.ToDouble(firstNumber);
            double secondNumberD = Convert.ToDouble(secondNumber);


            // calculates result of two numbers with different cases of operations
            CalculatorModel model = new CalculatorModel();
            double result = model.Calculate(firstNumberD, secondNumberD, enterOperator);

            // result Output
            ResultOutput(result, enterOperator);



            // return value of calculation in Console           
            GetUserInput("Press return to quit.");


        }
           
               
    //add mehtod for result output here

        static void ResultOutput(double result, string enterOperator)
        {
            switch (enterOperator)
            {

                case "+":
                    Console.WriteLine("The result of the addition is: {0}", result);
                    break;

                case "-":
                    Console.WriteLine("The result of the subtraction is: {0}", result);
                    break;

                case "*":
                    Console.WriteLine("The result of the multiplication is: {0}", result);
                    break;

                case "/":
                    Console.WriteLine("The result of the division is: {0}", result);
                    break;

                default:
                    Console.WriteLine("Invalid Input of operator");
                    break;

            }
        }
     
        static string GetUserInput(string Consoletext)
        {

            Console.Write(Consoletext);
            string numberCalg = Console.ReadLine();


            return numberCalg;
        }

        

        


            


    }



}