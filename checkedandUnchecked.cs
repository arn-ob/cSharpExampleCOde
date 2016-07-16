using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class checkedandUnchecked
    {


        public static void Main()
        {
            //byte b = 255;
            //checked
            //{
            //    b++;
            //    //Console.WriteLine("The b = "+b.ToString());
            //}
            //Console.WriteLine("The b = " + b.ToString());
            //Console.ReadLine();

            //int i = 10;

            //if (i is int)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            object s1 = "Hellow";
            object num = 1;

            string s11 = s1 as string;
            string s2 = num as string; 


                Console.WriteLine(s11);
            Console.WriteLine(s2);


            Console.ReadLine();


        }


    }
}
