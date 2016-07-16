using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    interface work1
    {
        void Print();
    }
    interface work2
    {
        void Print2();
    }

    class Simple : work1, work2
    {
        public void Print()
        {
            Console.WriteLine("This is calling a simple class ");
        }
        public void Print2()
        {
            Console.WriteLine("This is calling Oanther simple class ");
        }
    }



    class interfaceCheck
    {
        static void Main()
        {
            Simple sc = new Simple();
            work1 clc1 = (work1)sc;
            work2 clc2 = (work2)sc;

            sc.Print();
            clc1.Print();
            clc2.Print2();

            Console.ReadLine();

        }



    }
}
