using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class learningObject{

        public string i = "arnob";

    }

    class MainClass{

        static void Main(){

            object a;
            a = 1;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.ToString());



            a = new learningObject();

            learningObject classref;
            classref = (learningObject)a;
            Console.WriteLine(classref.i);
            Console.WriteLine(classref.i.GetType());
            Console.ReadLine();


        }


    }
}
