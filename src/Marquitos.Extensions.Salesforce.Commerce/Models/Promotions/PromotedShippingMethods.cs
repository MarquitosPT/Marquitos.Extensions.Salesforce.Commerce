using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a list of promoted shipping methods.
    /// </summary>
    public class PromotedShippingMethods
    {
        /// <summary>
        /// Creates a new instance of the PromotedShippingMethods class with an empty list of values.
        /// </summary>
        public PromotedShippingMethods()
        { }

        /// <summary>
        /// Creates a new instance of the PromotedShippingMethods class with a single value.
        /// </summary>
        /// <param name="value"></param>
        public PromotedShippingMethods(string value)
        {
            Values = new() { value };
        }

        /// <summary>
        /// Creates a new instance of the PromotedShippingMethods class with a list of values.
        /// </summary>
        /// <param name="values"></param>
        public PromotedShippingMethods(IEnumerable<string> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the PromotedShippingMethods class with a variable number of values.
        /// </summary>
        /// <param name="values"></param>
        public PromotedShippingMethods(params string[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// List of shipping method IDs to be promoted.
        /// </summary>
        [XmlElement("method-id")]
        public List<string> Values { get; set; } = new();
    }
}
