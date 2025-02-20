using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less1.validators
{
    internal class intValidator
    {
        static public bool Validate(int  value)
        => value > 0;
    }
}
