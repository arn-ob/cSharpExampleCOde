using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class GenericLearn
    {


        ///<summary>
        ///ref can be use .... if you not use that goes not effect any 
        ///problem at the code or program . 
        /// </summary>

        //public static void swap<T>(ref T x,ref T y)
       
        public static void swap<T>(T x,T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main()
        {
            int i = 10;
            int j = 20;

            //swap<int>(ref i,ref j);
            swap<int>( i,  j);

            Console.WriteLine(i);
            Console.WriteLine(j);

            string name1 = "Arnob";
            string name2 = "Shuvo";
            
            //swap<string>(ref name1,ref name2);
            swap<string>( name1, name2);

            Console.WriteLine(name1);
            Console.WriteLine(name2);

            Console.ReadLine();
            
        }
    }
}
