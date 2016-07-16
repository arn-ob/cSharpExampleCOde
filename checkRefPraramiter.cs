using System;

namespace learnFormEvent
{

    


    /// <summary>
    ///    The main exucation 
    /// </summary>
    class checkRefPraramiter
    {

        public static void change(string y)
        {
            y = "Change";
        }

        public static void change(ref string y)
        {
            y = "Ref key word use";

        //////}


        public static void Main()
        {

            string x = "Hellow";

            Console.WriteLine(x);
            change(x);
            Console.WriteLine(x);
            change(ref x);
            Console.WriteLine(x);
            Console.ReadLine();


        }

        

    }
}
