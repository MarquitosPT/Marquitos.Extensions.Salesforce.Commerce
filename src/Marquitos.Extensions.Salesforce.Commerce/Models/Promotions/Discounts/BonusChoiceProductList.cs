using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a list of bonus products associated with a discount.
    /// </summary>
    public class BonusChoiceProductList
    {
        /// <summary>
        /// Creates a new instance of <see cref="BonusChoiceProductList"/> with an empty list of bonus products.
        /// </summary>
        public BonusChoiceProductList()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="BonusChoiceProductList"/> with the specified bonus products.
        /// </summary>
        /// <param name="bonusProducts"></param>
        public BonusChoiceProductList(IEnumerable<BonusProduct> bonusProducts)
        {
            BonusProducts = new(bonusProducts);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusChoiceProductList"/> with the specified bonus products.
        /// </summary>
        /// <param name="bonusProducts"></param>
        public BonusChoiceProductList(params BonusProduct[] bonusProducts)
        {
            BonusProducts = new(bonusProducts);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusChoiceProductList"/> with the specified bonus product.
        /// </summary>
        /// <param name="bonusProduct"></param>
        public BonusChoiceProductList(BonusProduct bonusProduct)
        {
            BonusProducts = new() { bonusProduct };
        }

        /// <summary>
        /// Creates a new instance of <see cref="BonusChoiceProductList"/> with the specified product ID and price.
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="price"></param>
        public BonusChoiceProductList(string productID, decimal price = 0)
        {
            BonusProducts = new() { new BonusProduct(productID, price) };
        }

        /// <summary>
        /// List of bonus products
        /// </summary>
        [XmlElement("bonus-product")]
        public List<BonusProduct> BonusProducts { get; set; } = new();
    }
}
