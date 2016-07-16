using System;

namespace learnFormEvent
{

   class Myhight
    {
       
        public static int Hello { get; set; }
    }


    class Explicitly_Implement_two_interfaces
    {
        static void Main()
        {
            Myhight nn = new Myhight();
            nn.Hello = 28;
            Console.WriteLine("Hellow : {0}", nn.Hello);
            Console.ReadLine();

        }
    }
}
