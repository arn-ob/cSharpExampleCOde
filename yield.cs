using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    public class yielda
    {

        public IEnumerator GetEnumerator()
        {
            yield return "Hello";
            yield return "go";

        }
        
        
        public class program
        {
            
            public static void Main()
            {
                yielda get = new yielda();
           
                foreach (string s in get)
                {
                    Console.WriteLine(s);
                   
                }
                Console.ReadLine();
            }
        }


    }
}
