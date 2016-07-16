using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class testingEmu
    {
        struct tryit
        {
            public double Lenght;
            public double Width;
 
            tryit(double lenght , double width){
                Lenght = lenght;
                Width = width;
            }

            public double sum
            {
                get
                {
                    return Math.Sqrt(Lenght * Lenght + Width * Width);
                }
            }
        }
    }
}
