using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a list of mutually exclusive promotions.
    /// </summary>
    public class MutuallyExclusivePromotions
    {
        /// <summary>
        /// Creates a new instance of the MutuallyExclusivePromotions class.
        /// </summary>
        public MutuallyExclusivePromotions()
        { }

        /// <summary>
        /// Creates a new instance of the MutuallyExclusivePromotions class with a single promotion.
        /// </summary>
        /// <param name="value"></param>
        public MutuallyExclusivePromotions(string value)
        {
            Values = new() { value };
        }

        /// <summary>
        /// Creates a new instance of the MutuallyExclusivePromotions class with a list of promotions.
        /// </summary>
        /// <param name="values"></param>
        public MutuallyExclusivePromotions(IEnumerable<string> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the MutuallyExclusivePromotions class with a variable number of promotions.
        /// </summary>
        /// <param name="values"></param>
        public MutuallyExclusivePromotions(params string[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// List of mutually exclusive promotions
        /// </summary>
        [XmlElement("mutually-exclusive-promotion")]
        public List<string> Values { get; set; } = new();
    }
}
