using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums.Conditions
{
    /// <summary>
    /// Product promotion condition type
    /// </summary>
    public enum ProductPromotionConditionType
    {
        /// <summary>
        /// The product quantity condition type
        /// </summary>
        [XmlEnum("product-quantity")]
        ProductQuantity,

        /// <summary>
        /// The product amount condition type
        /// </summary>
        [XmlEnum("product-amount")]
        ProductAmount,
    }
}
