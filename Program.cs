using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave1();
            // Opgave2();
            // Opgave3();
            Opgave4();

            Console.ReadKey();
        }

        /// <summary>
        /// Create a program (in C#) to print Hello on screen and then print your name (in a separate line). 
        /// </summary>
        static void Opgave1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Claus");
        }

        /// <summary>
        /// Write a C# program to print the result of adding 12 and 13 on screen. 
        /// </summary>
        static void Opgave2()
        {
            int result = 12 + 13;
            Console.WriteLine(12 + 13);
        }

        /// <summary>
        /// Write a C# program to print the result of dividing 24 into 5 on screen. 
        /// </summary>
        static void Opgave3()
        {
            float dividend = 24;
            float devisor = 5;
            float result = dividend / devisor;
            Console.WriteLine(result);
        }

        /// <summary>
        /// Create a C# program to print the result of the following operations: 
        /// • -1 + 3 * 5 
        /// • (24+5) % 7 
        /// • 15 + -4*6 / 11 
        /// • 2 + 10 / 6 * 1 - 7 % 2 
        /// </summary>
        static void Opgave4()
        {
            Console.WriteLine(-1 + 3 * 5);
            Console.WriteLine((24 + 5) % 7);
            Console.WriteLine(15 + -4 * 6 / 11);
            Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);
        }
    }
}
