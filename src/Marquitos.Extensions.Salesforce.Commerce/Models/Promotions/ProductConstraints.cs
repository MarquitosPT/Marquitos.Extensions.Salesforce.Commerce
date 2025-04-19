using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of product constraints for a promotion.
    /// </summary>
    public class ProductConstraints
    {
        /// <summary>
        /// List of product constraints
        /// </summary>
        [XmlElement("product-constraint")]
        public List<ProductConstraint> Constraints { get; set; } = new();
    }
}
