using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class Property_Advance
    {
        private int month  ;
        public int Month { 

            get{ return month; } 
            
            set{
                //int valu;
                if(value > 0 && value < 13){
                    month = value;
                }
                else
                {
                    Console.WriteLine("Its out of range");
                }
            }
        }

    }

    class MainWork
    {
        static void Main(){ 

            Property_Advance prop = new Property_Advance();
            prop.Month = 60;
           //double s = prop.Meneteis;
            Console.WriteLine("hellow "+ prop.Month);
            Console.ReadLine();
        }
    }
}
