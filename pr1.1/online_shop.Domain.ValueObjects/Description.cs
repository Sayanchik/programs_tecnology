using online_shop.Domain.ValueObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_shop.Domain.ValueObjects.Validators;

namespace online_shop.Domain.ValueObjects
{
    /// <summary>
    /// Represents type of the entity's description.
    /// </summary>
    /// <param name="description">The description of the entity.</param>
    public class Description(string description)
        : ValueObject<string>(new DescriptionValidator(), description);
}
