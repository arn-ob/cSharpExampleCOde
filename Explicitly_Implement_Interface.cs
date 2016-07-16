using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    //Explicitly Implement Interface Members 

    interface Idestance
    {
        float getLenth();
        float getwidth();
        float opparatin();
    }

    class Box : Idestance
    {
        float Length;
        float width;
        Box(float let ,float wid)
        {
            Length = let;
            width = wid;
        }

       float Idestance.getLenth()
       {
            return Length;
       }

       float Idestance.getwidth()
       {
           return width;
       }

       float Idestance.opparatin()
       {
           return width * Length;
       }


       static void Main()
       {
           Box bx = new Box(25f, 26f);

           Idestance ids = (Idestance)bx;

           Console.WriteLine("This is the length {0}",ids.getLenth());
           Console.WriteLine("This is the width {0}", ids.getwidth());
           Console.WriteLine("This is the width {0}", ids.opparatin());
           Console.ReadLine();

       }
    


    }
}
