using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using online_shop.Domain.ValueObjects.Base;
using online_shop.Domain.ValueObjects.Exceptions;

namespace online_shop.Domain.ValueObjects.Validators
{
    public class TitleValidator : IValidator<string>
    { 
        /// <summary>
        /// The Title's min length
        /// </summary>
        public static int MIN_LENGTH => 3;

        /// <summary>
        /// The Title's max length
        /// </summary>
        public static int MAX_LENGTH => 50;

        /// <summary>
        /// Verifies the string to make sure it is not null, empty or doesn't consists only white-space characters. 
        /// </summary>
        /// <param name="value">A string containing data.</param>
        /// <exception cref="ArgumentNullOrWhiteSpaceException"></exception>
        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(nameof(value), ExeptionMessages.TITLE_NOT_NULL_OR_WHITE_SPACE);
            if (value.Length > MAX_LENGTH)
                throw new TitleLongValueException(value, MAX_LENGTH);
            if (value.Length < MIN_LENGTH)
                throw new TitleShortValueException(value, MIN_LENGTH);
        }
    }
}
