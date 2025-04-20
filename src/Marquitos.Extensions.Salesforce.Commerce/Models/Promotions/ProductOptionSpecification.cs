using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a specification for product options in the Salesforce Commerce system.
    /// </summary>
    public class ProductOptionSpecification
    {
        /// <summary>
        /// List of product ids.
        /// </summary>
        [XmlElement("product-option-id")]
        public List<string> Values { get; set; } = new();
    }
}
