using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask_4
{
    class SavingAccount : Account
    {
        public double Rate { get; set; }
        public SavingAccount(string name = "" , double balance = 0.0, double rate = 0.0): base(name, balance)
        {
            Rate = rate;
        }

       

    }
}
