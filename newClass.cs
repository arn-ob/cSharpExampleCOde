using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{

    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance
        {
            get;
        }
    }

}


namespace learnFormEvent.saverAc
{
    public class SaverAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw attempt failed");
            return false; 
        }

        public decimal Balance
        {
            get
            {
                return balance;

            }

        }

        public override string ToString()
        {
            return string.Format("Venus bank saver : balance = {0,6:C} ",balance);
        }

    }
}



namespace learnFormEvent.GoldAc
{

    public class GoldAccount
    {
        void GoldAcc(){
            Console.WriteLine("You need a gold account");
        }
    }











}









