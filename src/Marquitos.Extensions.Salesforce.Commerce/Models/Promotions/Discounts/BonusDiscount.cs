using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a bonus discount on a product.
    /// </summary>
    public class BonusDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="BonusDiscount"/>.
        /// </summary>
        public BonusDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="BonusDiscount"/> with the specified bonus products.
        /// </summary>
        /// <param name="bonusProducts"></param>
        public BonusDiscount(BonusProductList bonusProducts)
        {
            BonusProducts = bonusProducts;
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusDiscount"/> with the specified product ID.
        /// </summary>
        /// <param name="productID"></param>
        public BonusDiscount(string productID)
        {
            BonusProducts = new BonusProductList(productID);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusDiscount"/> with the specified product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        public BonusDiscount(IEnumerable<string> productIDs)
        {
            BonusProducts = new BonusProductList(productIDs);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusDiscount"/> with the specified product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        public BonusDiscount(params string[] productIDs)
        {
            BonusProducts = new BonusProductList(productIDs);
        }

        /// <summary>
        /// Bonus product list
        /// </summary>
        [XmlElement("bonus-products")]
        public BonusProductList BonusProducts { get; set; } = new();
    }
}
