using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// Qus : 
    /// Write a program to find out greatest common divisor (GCD) of two integers
    /// </summary>

    class ImageProcessingProblem4
    {
        static void Main(string[] args)
        {
            int num1, num2, i, m, x;
            Console.WriteLine("\n Enter 1st number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter 2nd number : ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                m = num2;
            else
                m = num1;

            for (i = m; i >= 1; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    Console.WriteLine("GCD of " + num1 + " and " + num2 + " is  : " + i);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
