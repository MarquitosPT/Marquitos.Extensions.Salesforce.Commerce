using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered
{
    /// <summary>
    /// Represents a collection of tiered product discounts in the Salesforce Commerce system.
    /// </summary>
    public class TieredProductDiscounts : PromotionDiscount
    {
        /// <summary>
        /// List of tiered product discounts.
        /// </summary>
        [XmlElement("discount")]
        public List<TieredProductDiscount> Discounts { get; set; } = new();

        /// <summary>
        /// The type of condition for the discount.
        /// </summary>
        [XmlAttribute("condition-type")]
        public ProductPromotionConditionType ConditionType { get; set; } = ProductPromotionConditionType.ProductQuantity;
    }
}
