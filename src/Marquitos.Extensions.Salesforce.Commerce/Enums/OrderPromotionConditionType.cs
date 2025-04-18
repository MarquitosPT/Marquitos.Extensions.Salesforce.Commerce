using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Order promotion condition type
    /// </summary>
    public enum OrderPromotionConditionType
    {
        /// <summary>
        /// The order total condition type
        /// </summary>
        [XmlEnum("order-total")]
        OrderTotal,

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
