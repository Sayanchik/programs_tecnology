using online_shop.Domain.ValueObjects.Base;
using online_shop.Domain.ValueObjects.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.ValueObjects
{
    /// <summary>
    /// Represents type of the entity's title.
    /// </summary>
    /// <param name="title">The title of the entity.</param>
    public class Title(string title) : ValueObject<string>(new TitleValidator(), title);
}
