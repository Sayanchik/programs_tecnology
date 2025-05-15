using online_shop.Domain.Ecxeptions;
using online_shop.Domain.ValueObjects;
using online_shop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.Entities
{
    public class Admin(Guid id, Username username) : Entity<Guid>(id)
    {
        #region Fields
        private readonly ICollection<Product> _products = [];

        #endregion // Fields

        #region Properties
        /// <summary> 
        /// Gets the seller's Username. 
        /// </summary>
        public Username Username { get; private set; } = username ?? throw new ArgumentNullValueException(nameof(username));


        #endregion // Properties

        /// <summary> 
        /// Changes the admin's username. 
        /// </summary>
        /// <param name="newUsername">New admin's username.</param>
        internal bool ChangeUsername(Username newUsername)
        {
            if (Username == newUsername) return false;
            Username = newUsername;
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        public void addProduct(Product product)
        {
            
        }
    }
}
