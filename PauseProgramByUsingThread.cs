using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class Program
    {
        static void Main(string[] ar)
        {

            if (ar.Length > 0)
            {
                Console.WriteLine("1st ar {0}",ar);
            }
            else
            {
                hellow();
            }
            Thread.Sleep(1000);
        }

        
        public static void hellow()
        {
            Console.WriteLine("I print a hello world ");
        }
        public static void hellow(string a)
        {
            Console.WriteLine("My custom type {0}", a);
        }

        //System.Diagnostics.Debugger.assat;
    }
}
