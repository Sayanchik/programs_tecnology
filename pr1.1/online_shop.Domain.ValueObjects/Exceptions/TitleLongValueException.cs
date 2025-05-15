using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.ValueObjects.Exceptions
{
    internal class TitleLongValueException(string title, int maxLength) : FormatException($"Title length {title} greater than maximum allowed length {maxLength}")
    {
        public string Title => title;
        public int MaxLength => maxLength;
    }
}
