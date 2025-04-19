using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Bonus product associated with a discount.
    /// </summary>
    public class BonusProduct
    {
        /// <summary>
        /// Creates a new instance of <see cref="BonusProduct"/> with default values.
        /// </summary>
        public BonusProduct()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="BonusProduct"/> with the specified product ID and price.
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="price"></param>
        public BonusProduct(string productID, decimal price = 0)
        {
            ProductID = productID;
            Price = price;
        }

        /// <summary>
        /// Bonus product price.
        /// </summary>
        [XmlElement("bonus-product-price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Product ID of the bonus product.
        /// </summary>
        [XmlAttribute("product-id")]
        public string ProductID { get; set; } = null!;
    }
}
