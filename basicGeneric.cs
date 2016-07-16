using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class BasicGeneric
    {
        static void Main()
        {
            List<int> ls = new List<int>();

            ls.Add(40);
            ls.Add(80);

            List<string> st = new List<string>();

            st.Add("Arnob");
            foreach (int i in ls)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        
        
        
        }


        
       

    }
}
