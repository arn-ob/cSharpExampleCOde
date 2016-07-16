using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{

    /// <summary>
    /// Qus : 
    /// . Write a program to display all the Armstrong number between two intervals
    /// </summary>

    class ImageProcessingProblem5
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int i, temp, num, rem =0;
            Console.WriteLine("\n Enter 1st number : ");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter 2nd number : ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Armstrong numbers between " + n1 + " and " + n2 + " are:  ");

            for (i = n1 + 1; i < n2; ++i)
            {
                temp = i;
                num = 0;
                do
                {
                    rem = (temp % 10);
                    num += rem * rem * rem;
                    temp /= 10;
                    Console.WriteLine(temp);
                } while (temp != 0);
               
                if (i == num)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
