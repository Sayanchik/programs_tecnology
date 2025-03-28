using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemOfBankAccount.Base;

namespace systemOfBankAccount
{
    internal class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string owner, decimal initialBalance) : base(owner, initialBalance) { }
        

        public override void PerforMonthAndTransactions()
        {
            if (Balance > 500m)
                MakeDeposite(Balance * 0.1m, DateTime.Now, "apply Monthly Interest");
        }
    }

}
