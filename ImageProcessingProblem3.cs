using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class ImageProcessingProblem3
    {
        /// <summary>
        /// Qus : 
        /// Write a program to find out roots of a quadratic equation ax2+bx+c=0 where a, b and c are coefficients.
        /// </summary>
        

        static void Main(string[] args)
        {
            double a, b, c, d, r1, r2;
            Console.Write("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for c : ");
            c = double.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d > 0)
            {
                r1 = (-b + Math.Sqrt(d)) / (2 * a);
                r2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are :  " + r1 + " and " + r2);
            }
            else if (d == 0)
            {
                r1 = r2 = -b / (2 * a);
                Console.WriteLine("Roots are :  " + r1 + " and " + r2);
            }
            else
            {
                r1 = -b / (2 * a);
                r2 = Math.Sqrt(-d) / (2 * a);
                Console.WriteLine("Roots are :  " + r1 + " + " + r2 + "i \n     and " + r1 + " - " + r2 + "i");

            }
            Console.ReadLine();

        }

    }
}
