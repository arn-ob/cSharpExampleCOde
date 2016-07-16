using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{

    public class typeProparty
    {

        public int number{set;get;}

        public int multi(int num)
        {
            int sum = num * number;
            return sum;
        }

        public typeProparty()
        {
            number = 0;
        }
    }



   class testProperty
    {
         public static void work()
        {

            typeProparty pro = new typeProparty();

            pro.number = 20;

            int result = pro.multi(4);
           // if (x > 0)
           // {
            //    Console.WriteLine("I Type this at the command line {0}", x);
            //}
            Console.WriteLine(result);
            Console.ReadLine();


        }
       



    }
}
