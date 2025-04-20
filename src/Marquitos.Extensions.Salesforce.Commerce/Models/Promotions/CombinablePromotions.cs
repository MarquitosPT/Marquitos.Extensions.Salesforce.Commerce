using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a list of combinable promotions.
    /// </summary>
    public class CombinablePromotions
    {
        /// <summary>
        /// Creates a new instance of the CombinablePromotions class.
        /// </summary>
        public CombinablePromotions()
        { }

        /// <summary>
        /// Creates a new instance of the CombinablePromotions class with a single promotion.
        /// </summary>
        /// <param name="value"></param>
        public CombinablePromotions(string value)
        {
            Values = new() { value };
        }

        /// <summary>
        /// Creates a new instance of the CombinablePromotions class with a list of promotions.
        /// </summary>
        /// <param name="values"></param>
        public CombinablePromotions(IEnumerable<string> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the CombinablePromotions class with a variable number of promotions.
        /// </summary>
        /// <param name="values"></param>
        public CombinablePromotions(params string[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// List of combinable promotions
        /// </summary>
        [XmlElement("combinable-promotion")]
        public List<string> Values { get; set; } = new();
    }
}
