using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a product combination for a promotion.
    /// </summary>
    public class ProductCombination
    {
        /// <summary>
        /// Product constraints for the combination.
        /// </summary>
        [XmlElement("product-constraints")]
        public ProductConstraints ProductConstraints { get; set; } = new();
    }
}
