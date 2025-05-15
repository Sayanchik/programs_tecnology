using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_shop.Domain.Entities;

namespace online_shop.Domain.Entities
{
    internal class Cart(Guid cartID, Guid customerID)
    {
        private Guid _cartID = cartID;

        private Guid _customerID = customerID;/// <summary>
        /// ???  не понимаю
        /// </summary>

        private List<CartItem> _cartItems = new List<CartItem>();//(?)

        public Guid cartID { get; set; } 

        public Guid customerID { get; set; } = Guid.Empty;///(?)
    }
}
