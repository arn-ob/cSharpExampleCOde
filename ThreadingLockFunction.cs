using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace learnFormEvent
{



    /// <summary>
    /// The following sample uses threads and lock. As long as the lock statement is present, 
    /// the statement block is a critical section and balance will never become a negative number.
    /// </summary>
    class ThreadingLockFunction
    {
        private object thisLock = new object();
        int balance;

        Random rm = new Random();

        public void Account(int bal){
            balance = bal;
            
        }

        int Withdraw(int amount){
            if (balance < 0)
            {
                throw new Exception("You have not enough balance");
            }

            lock (thisLock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine("Balance before Withdrawal :  " + balance);
                    Console.WriteLine("Amount to Withdraw        : -" + amount);
                    balance = balance - amount;
                    Console.WriteLine("Balance after Withdrawal  :  " + balance);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
			{
			 Withdraw(rm.Next(1,100));
			}
        }

        static void Main()
        {
            Thread[] thread = new Thread[10];
            ThreadingLockFunction ac = new ThreadingLockFunction();
            ac.Account(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(ac.DoTransactions));
                thread[i] = t;
 
            }
            for (int i = 0; i < 10; i++)
            {
                thread[i].Start();
            }

            Console.ReadLine();
        }

    }
}
