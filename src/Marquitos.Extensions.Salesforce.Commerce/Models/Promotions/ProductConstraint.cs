using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a constraint on a product for a promotion.
    /// </summary>
    public class ProductConstraint
    {
        /// <summary>
        /// Quantity of products
        /// </summary>
        /// <remarks>Min value 0</remarks>
        [XmlElement("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Product specification
        /// </summary>
        [XmlElement("product-specification")]
        public ProductSpecification ProductSpecification { get; set; } = new();
    }
}
