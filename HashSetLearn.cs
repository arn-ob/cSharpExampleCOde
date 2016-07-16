using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class Program
    {
        static void NotRealMain()
        {

            /// Deferred Query Execution 
            ///
            List<string> names = new List<string>
            {
                "arnob",
                "soton",
                "shovon"
            };

            var namewitha = from n in names where n.StartsWith("a") orderby n select n;

            Console.WriteLine("First search");
            foreach (string name in namewitha)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names.Add("New");
            names.Add("New 2");
            names.Add("Tonmy");

            Console.WriteLine("2nd search");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();


            /// Type Filting  
            /// 

            object[] data = { "afsdhv", 4, 4, "fsdhvb" };

            var quary = data.OfType<int>();

            foreach (var item in quary)
            {
                Console.WriteLine(item);
            }


            
            Console.ReadLine();
        }
    }
    
}
