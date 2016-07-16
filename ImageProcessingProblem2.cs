using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// Qus :
    /// Write a program that swap two number without using any extra variable.
    /// </summary>


    class ImageProcessingProblem2
    {
        static void Main(string[] args)
        {
            int a=9, b=5;
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Swaped ... \n A = " + a + "\n B = " + b );
            Console.ReadLine();

        }
    }
}



