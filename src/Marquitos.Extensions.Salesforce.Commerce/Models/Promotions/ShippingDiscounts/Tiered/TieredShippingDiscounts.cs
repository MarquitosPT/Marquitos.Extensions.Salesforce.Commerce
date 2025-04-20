using Marquitos.Salesforce.Commerce.Enums.Conditions;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts.Tiered
{
    /// <summary>
    /// Represents a collection of tiered shipping discounts in the Salesforce Commerce system.
    /// </summary>
    public class TieredShippingDiscounts : ShippingDiscount
    {
        /// <summary>
        /// List of tiered Shipping discounts.
        /// </summary>
        [XmlElement("discount")]
        public List<TieredShippingDiscount> Discounts { get; set; } = new();

        /// <summary>
        /// The type of condition for the discount.
        /// </summary>
        [XmlAttribute("condition-type")]
        public ShippingPromotionConditionType ConditionType { get; set; } = ShippingPromotionConditionType.ShipmentTotal;
    }
}
