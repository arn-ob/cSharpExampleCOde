using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    public class BaseA
    {
        public static int x = 100;
        public static int y = 200;
    } 
    public class newModifier :BaseA
    {
        new public static int x = 300;
        static void Main()
        {
            Console.WriteLine(x);
            Console.WriteLine(BaseA.x);
            Console.WriteLine(y);
            Console.ReadLine();
        }



    }
}
