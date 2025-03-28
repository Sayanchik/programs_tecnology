using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemOfBankAccount.Base;

namespace systemOfBankAccount
{
    internal class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string owner, decimal initialBalance) : base(owner, initialBalance) { }


        public override void PerforMonthAndTransactions()
        {
            MakeWithdrawal(-Balance, DateTime.Now, "деняк нет");
        }
    }
}
