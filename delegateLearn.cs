using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class delegateLearn
    {

        delegate string delegateTest(string val);

        static void Main()
        {
            string mid = " , Middle part ";
            delegateTest anondel = delegate(string param){
                param += mid ;
                param += "And this was added to the string ";
                return param;
            };

            Console.WriteLine(anondel("start of string "));
            Console.ReadLine();
        }
    }
}
