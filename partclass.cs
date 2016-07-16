using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    public partial class class1{

        private int num1;
        private int num2;

        public class1(int x,int y)
        {
            this.num1 = x;
            this.num2 = y;
        }
    }
    public partial class class1
        {
            public void print(){
            Console.WriteLine("Here your Result {0} , {1} ",num1,num2);
            }
    }

    public class main
        {
            public static void Main()
            {
                class1 create = new class1(50,60);
                create.print();

                Console.WriteLine("Enter to Exit");
                Console.ReadLine();
            }
    }



    
   


}
