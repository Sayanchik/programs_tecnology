using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemOfBankAccount.valueObject;

namespace systemOfBankAccount.Base
{
    abstract class BankAccount
    {
        private List<transaction> _allTransaction = new List<transaction>();

        private static NumberOfBankAccount s_accountNumberSeed = new(1000000000);

        public NumberOfBankAccount Number { get; }

        public string Owner { get; private set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }


        public BankAccount(string owner, decimal initialBalance)
        {
            Number = s_accountNumberSeed;
            s_accountNumberSeed.Value++;
            Owner = owner;
            MakeDeposite(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposite(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), $"Amount of deposite must be positive ({amount})");

            var deposite = new transaction(amount, date, note);
            _allTransaction.Add(deposite);
        }


        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), $"Amount of withdrawal must be positive ({amount})");

            if (Balance - amount <= 0)
                throw new InvalidOperationException("Not sufficient rubls for this withdrawal");

            _allTransaction.Add(new transaction(-amount, date, note));
        }

        public string GetHistoryOfTransaction()
        {
            StringBuilder str = new StringBuilder();
            foreach (var elem in _allTransaction)
                str.AppendLine( elem.ToString());

            return str.ToString();
        }

        public abstract void PerforMonthAndTransactions();
    }
}
