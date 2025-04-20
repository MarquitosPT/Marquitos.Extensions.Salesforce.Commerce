using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a list of payment methods to be promoted.
    /// </summary>
    public class PromotedPaymentMethods
    {
        /// <summary>
        /// Creates a new instance of the PromotedPaymentMethods class.
        /// </summary>
        public PromotedPaymentMethods()
        { }

        /// <summary>
        /// Creates a new instance of the PromotedPaymentMethods class with a single value.
        /// </summary>
        /// <param name="value"></param>
        public PromotedPaymentMethods(string value)
        {
            Values = new() { value };
        }

        /// <summary>
        /// Creates a new instance of the PromotedPaymentMethods class with a list of values.
        /// </summary>
        /// <param name="values"></param>
        public PromotedPaymentMethods(IEnumerable<string> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the PromotedPaymentMethods class with a variable number of values.
        /// </summary>
        /// <param name="values"></param>
        public PromotedPaymentMethods(params string[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// List of payment method IDs to be promoted.
        /// </summary>
        [XmlElement("method-id")]
        public List<string> Values { get; set; } = new();
    }
}
