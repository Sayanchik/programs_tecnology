using online_shop.Domain.ValueObjects.Base;
using online_shop.Domain.ValueObjects.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.ValueObjects.Validators
{
    public class DescriptionValidator : IValidator<string>
    {
        /// <summary>
        /// Verifies the string to make sure it is not null, empty or doesn't consists only white-space characters. 
        /// </summary>
        /// <param name="value">A string containing data.</param>
        /// <exception cref="ArgumentNullOrWhiteSpaceException"></exception>
        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(nameof(value), ExeptionMessages.TITLE_NOT_NULL_OR_WHITE_SPACE);
        }
    }
}