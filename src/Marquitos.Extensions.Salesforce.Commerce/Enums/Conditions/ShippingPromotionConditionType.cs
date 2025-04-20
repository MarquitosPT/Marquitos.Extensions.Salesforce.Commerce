using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums.Conditions
{
    /// <summary>
    /// Shipping promotion condition type
    /// </summary>
    public enum ShippingPromotionConditionType
    {
        /// <summary>
        /// The shipment total condition type
        /// </summary>
        [XmlEnum("shipment-total")]
        ShipmentTotal,

        /// <summary>
        /// The product quantity condition type
        /// </summary>
        [XmlEnum("product-quantity")]
        ProductQuantity,

        /// <summary>
        /// The product combination condition type
        /// </summary>
        [XmlEnum("product-combination")]
        ProductCombination
    }
}
