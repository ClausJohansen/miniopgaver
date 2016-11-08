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
            // Opgave4();
            // Opgave5();
            Opgave6();

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

        /// <summary>
        /// Write a C# program to print the result of multiplying two numbers which will entered by the user.
        /// </summary>
        static void Opgave5()
        {
            try
            {
                int factor1;
                int factor2;

                Console.Write("Indtast første nummer: ");
                factor1 = int.Parse(Console.ReadLine());

                Console.Write("Indtast andet nummer: ");
                factor2 = int.Parse(Console.ReadLine());

                Console.WriteLine(factor1 + " x " + factor2 + " = " + (factor1 * factor2));
            }
            catch
            {
                Console.WriteLine("Noget gik galt. Indtast venligst kun tal.");
            }
        }

        /// <summary>
        /// Write a C# program to ask the user for three numbers and display their multiplication. The first line must be a comment with your name and surname. It MUST look as follows: 
        ///
        /// Enter the first number to multiply 
        /// 12 
        /// Enter the second number to multiply 
        /// 23 
        /// Enter the third number to multiply 
        /// 2 
        /// </summary>
        static void Opgave6()
        {
            try
            {
                int factor1, factor2, factor3;
                int result;

                Console.WriteLine("Enter the first number to multiply");
                factor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second to multiply");
                factor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third number to multiply");
                factor3 = int.Parse(Console.ReadLine());

                result = factor1 * factor2 * factor3;

                Console.WriteLine(String.Format("{0} x {1} x {2} = {3}", factor1, factor2, factor3, result));
            }
            catch
            {
                Console.WriteLine("Noget gik galt. Indtast venligst kun tal.");
            }
        }
    }
}
