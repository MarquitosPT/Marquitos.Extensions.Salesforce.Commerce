using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a list of bonus products associated with a discount.
    /// </summary>
    public class BonusProductList
    {
        /// <summary>
        /// Creates a new instance of <see cref="BonusProductList"/> with an empty list of product IDs.
        /// </summary>
        public BonusProductList()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="BonusProductList"/> with the specified product ID.
        /// </summary>
        /// <param name="productID"></param>
        public BonusProductList(string productID)
        {
            ProductIDs.Add(productID);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusProductList"/> with the specified product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        public BonusProductList(IEnumerable<string> productIDs)
        {
            ProductIDs.AddRange(productIDs);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusProductList"/> with the specified product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        public BonusProductList(params string[] productIDs)
        {
            ProductIDs.AddRange(productIDs);
        }

        /// <summary>
        /// List of product IDs for the bonus products.
        /// </summary>
        /// <remarks>Max 50 product ids</remarks>
        [XmlElement("product-id")]
        public List<string> ProductIDs { get; set; } = new();
    }
}
