using online_shop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.Entities
{
    public class Customer(Guid id, string customerName) : Entity<Guid>(id)
    {

    }
}
