using System;
using System.Collections.Generic;
using System.Text;


//Qus : Write a program to add 3 with every value of matrix A. 
//      A = [(127,10,198,53), (45,89,4,5), (2,200,25,58), (98,88,4,56)]


namespace learnFormEvent
{
    class ImageProcessingProblem1
    {
        static void Main(string[] args)
        {
            int i, j = 0, m = 0, n = 0;
            int[,] a = { { 127, 10, 198, 53 }, { 45, 89, 4, 5 }, { 2, 200, 25, 58 }, { 98, 88, 4, 56 } };
            int[,] b = { { 3, 3, 3, 3 }, { 3, 3, 3, 3 }, { 3, 3, 3, 3 }, { 3, 3, 3, 3 } };
            int[,] c = new int[4, 4];
            int f = c.Length;

            // One Process :) 
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(" ");

                for (j = 0; j < 4; j++)
                {
                    Console.Write(" " + a[i, j]);
                }

            }

            Console.Write("\n");

            for (m = 0; m < 4; m++)
            {
                Console.WriteLine(" ");

                for (n = 0; n < 4; n++)
                {
                    Console.Write(" " + b[m, n]);
                }

            }

            Console.Write("\n");

            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine("");
                for (int l = 0; l < 4; l++)
                {
                    // add the two array :D 
                    Console.Write(a[k, l] + b[k, l] + "\t");
                }
            }
            
            // End            
            
            ///   onather process ............ shoter  
            
            /// start  
            for ( j = 0; j < 4; j++)
            {
                Console.WriteLine("\t");
                for ( m = 0; m < 4; m++)
                {
                    Console.WriteLine(a[j, m] + b[j, m] + "\t");
                    
                }
            }
            /// End

            // wait for enter
            Console.ReadLine();

        }
    }
}