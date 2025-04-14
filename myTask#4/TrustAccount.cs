using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myTask_4
{
    class TrustAccount : SavingAccount
    {
        private int bounce = 50;
        private int count = 0;
        public TrustAccount(string name = "", double balance = 0.0, double rate = 0.0) : base(name, balance, rate)
        {
            
        }

        public override bool Deposit(double amount)
        {
            if(amount >= 5000)
            {
               return base.Deposit(amount + bounce);    
            }
            else if(amount > 0)
            {
                return base.Deposit(amount);
            }

                return false;
        }

        public override bool Withdraw(double amount)
        {
            int year = DateTime.Now.Year;
            count++;
            int i = 3;

            if (amount <= Balance * 0.2 && count <= i && year == DateTime.Now.Year)
            {
                return base.Withdraw(amount);
            }
            else if (DateTime.Now.Year > year)
            {
               
                return base.Withdraw(amount);
            }

            return false;
        }

    }
}
