using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// Get Documentation from : https://msdn.microsoft.com/en-us/library/bb383979.aspx
    /// </summary>
    class Contact1 
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public Contact1(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
    
    class Contact2
    {
        //private string name;
        //private string address;

        //public Contact2(string nAme, string aDdress)
        //{
        //    // TODO: Complete member initialization
        //    this.nAme = nAme;
        //    this.aDdress = aDdress;
        //}
        public string Name { get; private set; }
        public string Address { get; private set; }

        private Contact2(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public static Contact2 CreateContact (string nAme,string aDdress)
        {
            return new Contact2(nAme,aDdress);
        }
    }

    class MaiNWork 
    {
        static void Main()
        {
            string[] name = { "arnob", "tripto","shuvo" ,"alif" };
            string[] address = { "goran", "goran", "tongi","In front of my house" };

            var que1 = from i in Enumerable.Range(0, 4) select new Contact1(name[i], address[i]);
            var list = que1.ToList();
            foreach (var contact in list)
            {
                Console.WriteLine("Name : {0} , Address {1}", contact.Name, contact.Address);
            }

            var que2 = from i in Enumerable.Range(0, 4) select Contact2.CreateContact(name[i], address[i]);

            var list2 = que2.ToList();
            Console.WriteLine("\n");
            Console.WriteLine("From Data Contact2 ");
            foreach (var contact in list2)
            {
                Console.WriteLine("Name : {0} , Address {1}", contact.Name, contact.Address);
            }
            Console.ReadLine();
        }
    }

}
