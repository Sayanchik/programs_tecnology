using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemOfBankAccount.Base;

namespace systemOfBankAccount
{
    internal class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner, decimal initialBalance) : base(owner, initialBalance) { }


        public override void PerforMonthAndTransactions()
        {
            if (Balance < 0)
                MakeWithdrawal(Balance * 0.2m, DateTime.Now, "charge monthly interest");
        }

    }
}
