using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts.Tiered
{
    /// <summary>
    /// Represents a collection of tiered order discounts in the Salesforce Commerce system.
    /// </summary>
    public class TieredOrderDiscounts : OrderDiscount
    {
        /// <summary>
        /// List of tiered order discounts.
        /// </summary>
        [XmlElement("discount")]
        public List<TieredOrderDiscount> Discounts { get; set; } = new();

        /// <summary>
        /// The type of condition for the discount.
        /// </summary>
        [XmlAttribute("condition-type")]
        public OrderPromotionConditionType ConditionType { get; set; } = OrderPromotionConditionType.OrderTotal;
    }
}
