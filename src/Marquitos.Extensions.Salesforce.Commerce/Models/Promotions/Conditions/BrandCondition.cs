using Marquitos.Salesforce.Commerce.Enums.Comparators;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents a condition that checks for a specific brand in a promotion.
    /// </summary>
    public class BrandCondition : Condition<BrandComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="BrandCondition"/> with an empty list of values.
        /// </summary>
        public BrandCondition()
            : base(BrandComparator.Exists)
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of <see cref="BrandCondition"/> with the specified values.
        /// </summary>
        /// <param name="values"></param>
        public BrandCondition(IEnumerable<string> values)
            : base(BrandComparator.Exists)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BrandCondition"/> with the specified value.
        /// </summary>
        /// <param name="value"></param>
        public BrandCondition(string value) 
            : this(new[] { value })
        { }

        /// <summary>
        /// Creates a new instance of <see cref="BrandCondition"/> with the specified values and operator.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        public BrandCondition(IEnumerable<string> values, BrandComparator @operator)
            : base(@operator)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BrandCondition"/> with the specified value and operator.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        public BrandCondition(string value, BrandComparator @operator) 
            : this(new[] { value }, @operator)
        { }

        /// <summary>
        /// List of brands to check against.
        /// </summary>
        [XmlElement("brand")]
        public List<string> Values { get; set; }
    }
}
