using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{

    ///In C# 3.0 and later, auto-implemented properties make property-declaration more concise when
    ///no additional logic is required in the property accessors. They also enable client code to create objects. 
    ///When you declare a property as shown in the following example, the compiler creates a private, anonymous 
    ///backing field that can only be accessed through the property's get and set accessors.
    ///
    ///.................................................................................................
    ///
    // This class is mutable. Its data can be modified from 
    // outside the class. 
    class Customer
    {
        // Auto-Impl Properties for trivial get and set 
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

        // Constructor 
        public Customer(double purchases, string name, int ID)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerID = ID;
        }
        // Methods 
        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }

        // .. Additional methods, events, etc.
    }

    class Program
    {
        static void Main()
        {
            // Intialize a new object.
            Customer cust1 = new Customer(4987.63, "Northwind", 90108);

            //Modify a property
            cust1.TotalPurchases += 499.99;
        }
    }
}


