using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
   public class Auto_implementation
    {

        /// <summary>
        /// In C# 3.0 and later, auto-implemented properties make property-declaration more 
        /// concise when no additional logic is required in the property accessors. They also 
        /// enable client code to create objects. When you declare a property as shown in the 
        /// following example, the compiler creates a private, anonymous backing field that can 
        /// only be accessed through the property's get and set accessors.
        /// </summary>
        /// 
        /// The following example shows a simple class that has some auto-implemented properties:


        public string Address{get;set;}
        public string Name{get;set;}
        public int Roll{get;set;}

        public void CustomerName (string name,string address,int roll)
        {
           Name = name;
           Address = address;
           Roll = roll;
        }
    }


    class MainProgram
    {
        static void Main()
        {
            Auto_implementation cus = new Auto_implementation();
            cus.CustomerName("Arnob", "Goran", 19);

            Console.WriteLine("Name : " +cus.Name);
            Console.WriteLine("Address : " + cus.Address);
            Console.WriteLine("Roll : "+ cus.Roll);

            Console.ReadLine();

        }
        
        
    }

}
