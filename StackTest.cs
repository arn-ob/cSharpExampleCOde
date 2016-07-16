using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class StackTest
    {
        static void Main()
        {

            Stack<int> ch = new Stack<int>();
            ch.Push(1);
            ch.Push(2);


            foreach (var item in ch)
            {
                Console.WriteLine(item);
                
            }
            Console.ReadLine();
        }
    }
}
