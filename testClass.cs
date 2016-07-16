using System;

namespace learnFormEvent
{
    //class testClass
    //{
    //    //static void newFun(out int i)
    //    //{
    //    //    i = 100;
    //    //}

    //    //public static void Main()
    //    //{
    //    //    int i;
    //    //    newFun(out i);
    //    //    Console.WriteLine(i);
    //    //}

    //    static int newfar()
    //    {
    //        Int32 a = Int32.Parse(Console.ReadLine());
    //        return a;
    //    }


    //    static void newOut(out int i)
    //    {
    //        i = 100;
    //    }


    //    static void Main(string[] args)
    //    {
    //        if(args.Length>0)
    //        {
    //            Console.WriteLine("You Write : {0} ", args);
    //        }
    //        else
    //        {
    //            Console.WriteLine("You did Nothing ");
    //        }
            
    //        Console.WriteLine("Now i Do the internal things ");

    //        var a = newfar();

    //        int i;

    //        newOut(out i);

    //        i =  i + a;

    //        Console.WriteLine("REsult  {0} ", i);
            
    //    }
    //}


    public class Employee4
    {
        public string id;
        public string name;

        public Employee4()
        {
        }

        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }

    class MainClass : Employee4
    {
        static void Main()
        {
            Console.Write("Enter the employee's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the employee's ID: ");
            string id = Console.ReadLine();

            // Create and configure the employee object:
            Employee4 e = new Employee4(name, id);

            Console.Write("Enter the current number of employees: ");
            
            string n = Console.ReadLine();
            
            Employee4.employeeCounter = Int32.Parse(n);
            Employee4.AddEmployee();

            // Display the new information:
            Console.WriteLine("Name: {0}", e.name);
            Console.WriteLine("ID:   {0}", e.id);
            Console.WriteLine("New Number of Employees: {0}",Employee4.employeeCounter);
        }
    }
}
