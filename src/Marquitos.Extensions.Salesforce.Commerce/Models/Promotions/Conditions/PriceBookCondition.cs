using Marquitos.Salesforce.Commerce.Enums.Comparators;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents a condition that checks for specific price books in a promotion.
    /// </summary>
    public class PriceBookCondition :Condition<PriceBookComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="PriceBookCondition"/>.
        /// </summary>
        public PriceBookCondition()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="PriceBookCondition"/> with the specified values.
        /// </summary>
        /// <param name="values"></param>
        public PriceBookCondition(IEnumerable<string> values)
            : base(PriceBookComparator.StorefrontPriceInRecursive)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriceBookCondition"/> with the specified value.
        /// </summary>
        /// <param name="value"></param>
        public PriceBookCondition(string value)
            : this(new[] { value })
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriceBookCondition"/> with the specified values and operator.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        public PriceBookCondition(IEnumerable<string> values, PriceBookComparator @operator)
            : base(@operator)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriceBookCondition"/> with the specified value and operator.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        public PriceBookCondition(string value, PriceBookComparator @operator)
            : this(new[] { value }, @operator)
        {
        }

        /// <summary>
        /// List of pricebook IDs to check against.
        /// </summary>
        [XmlElement("pricebook-id")]
        public List<string> Values { get; set; } = new();
    }
}
