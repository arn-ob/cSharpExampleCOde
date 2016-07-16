using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{


    #region Learning Delegate
    class Delegates
    {
        delegate int numbers(int a);

        static int square(int x)
        {
            return x * x;
        }

        static void Main()
        {
            numbers x = square;


            int cal = x(5);
            Console.WriteLine(cal);
            Console.ReadLine();
        }

    }
    #endregion




}
