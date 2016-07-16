using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    public class Account
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }

        public Account(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }
    class AcuntByUsingGenerics
    {
        public static void Main()
        {
            List<Account> ac = new List<Account>();
            ac.Add(new Account("arnob", 5333));
            ac.Add(new Account("shuvo", 5555));
            ac.Add(new Account("tonmy", 533));

            foreach (var item in ac)
            {
                Console.WriteLine(ac);
                
            }

            Console.ReadLine();
        }

    }
}
