#undef DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class undefUse
    {

        static void Main()
        {
#if DEBUG
            Console.WriteLine("Debug is worked ");
#else
            Console.WriteLine("Debug is not working ");
#endif
            Console.ReadLine();
        }


    }
}
