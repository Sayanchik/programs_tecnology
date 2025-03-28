using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemOfBankAccount.valueObject
{
    struct transaction
    {
        public decimal Amount { get; }

        public string Note { get; }
        
        public DateTime Date { get; }

        public transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Note = note;
            Date = date;
        }

        public override string ToString()
        {
            return $"Date: {Date}\t Amount: {Amount}\t Note: {Note}";
        }
    }
}
