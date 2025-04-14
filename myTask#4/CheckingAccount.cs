using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask_4
{
     class CheckingAccount : Account
    {
       private double Fee = 1.5;
        public CheckingAccount(string name = "", double balance = 0.0):base(name , balance)
        {
           
        }


        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }



    }
}
