using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    //Work manager and normal employ relations
    class propertyWork
    {
        private string name;
        public string Name {

            get { return name; }
            set { name = value; }
        }
    }
    class manager : propertyWork
    {
        private string name;

        public new string Name
        {
            get { return name; }
            set
            {
                name = value +" ,Manager";
            }
        }
    }

    class mainClass
    {
        static void Main()
        {
            manager manage = new manager();
            manage.Name = "Arnob";
            ((propertyWork)manage).Name = "Shoton";

            Console.WriteLine(manage.Name);
            Console.WriteLine(((propertyWork)manage).Name);
            Console.ReadLine();
        }
    }



}
