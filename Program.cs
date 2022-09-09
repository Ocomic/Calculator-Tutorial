//New format of Console Script
//Console.WriteLine("Hello World!");



//Old format of Console Script

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello I am a program!");
            Console.WriteLine("Press any key to close the console.");

            // use ReadKey to close console by pressing any key
            // while (Console.ReadKey().Key != ConsoleKey.E) can be used to close console with E key for example
            Console.ReadKey();
            //use Console.ReadLine(); to colse console with enter key


        }

    }



}