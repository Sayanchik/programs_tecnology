using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less1.validators
{
    internal class stringValidator
    {
        static public bool Validate(string value)
            => !String.IsNullOrWhiteSpace(value);
    }
}
