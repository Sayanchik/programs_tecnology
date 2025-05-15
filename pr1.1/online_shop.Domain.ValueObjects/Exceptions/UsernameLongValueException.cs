using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.ValueObjects.Exceptions
{
    internal class UsernameLongValueException(string username, int maxLength)
        : FormatException($"Username length {username} greater than maximum allowed length {maxLength}")
    {
        public string Username => username;
        public int MaxLength => maxLength;
    }
}
