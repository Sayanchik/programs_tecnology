using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemOfBankAccount.valueObject
{
    struct NumberOfBankAccount
    {
        public long Value { get; set; }

        public NumberOfBankAccount(long value)
        {
            if (value < 1000000000 || value >= 10000000000)
                throw new ArgumentOutOfRangeException(nameof(value), "Error!");

            Value = value;
        }
    }
}
