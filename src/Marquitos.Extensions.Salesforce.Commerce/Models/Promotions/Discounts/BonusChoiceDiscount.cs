using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a bonus choice discount on a product.
    /// </summary>
    public class BonusChoiceDiscount : Discount
    {
        /// <summary>
        /// Bonus product list
        /// </summary>
        [XmlElement("bonus-products")]
        public BonusChoiceProductList BonusProducts { get; set; } = new();

        /// <summary>
        /// Maximum number of bonus items that can be selected.
        /// </summary>
        /// <remarks>Between 1 and 50.</remarks>
        [XmlElement("max-bonus-items")]
        public int MaxBonusItems { get; set; } = 1;
    }
}
