using online_shop.Domain.Ecxeptions;
using online_shop.Domain.Entities.Base;
using online_shop.Domain.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace online_shop.Domain.Entities
{
    public class Product() : Entity<Guid>()
    {
        #region Fields

        #endregion //Fields

        #region Properties

        ///// <summary>
        ///// get the product ID
        ///// </summary>
        //public Guid ProductID { get; }

        /// <summary>
        /// get the product name
        /// </summary>
        public Title Title { get; }

        /// <summary>
        /// get a product description
        /// </summary>
        public Description Description { get; }

        /// <summary>
        /// get the price of the product
        /// </summary>
        public decimal Price { get; }


        /// <summary>
        /// get the product category
        /// </summary>
        public string Category { get; }


        /// <summary>
        /// get an image of the product
        /// </summary>
        public string ImageURL { get; }


        /// <summary>
        /// get admin of the product
        /// </summary>
        public Admin Admin { get; }


        #endregion //Properties

        #region Constructor
        /*protected Product()
        {

        }*/

        /// <summary>
        /// Initializes a new instance of a <see cref="Product"></see> class.
        /// </summary>
        ///// <param name="productID">the product ID</param>
        /// <param name="title">the product name</param>
        /// <param name="Description">the product description</param>
        /// <param name="price">the price of the product</param>
        /// <param name="category">the product category</param>
        /// <param name="imageURL">image of the product</param>
        /// <param name="admin">admin of the product</param>
        /// 
        protected Product(
            Guid id,
            Title title,
            Description description,
            decimal price,
            string category,
            string imageURL,
            Admin admin) : base(id)
        {
            Title = title ?? throw new ArgumentNullValueException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            Category = category;
            ImageURL = imageURL;
            Admin = admin ?? throw new ArgumentNullException(nameof(admin));

        }
        #endregion
    }
}
