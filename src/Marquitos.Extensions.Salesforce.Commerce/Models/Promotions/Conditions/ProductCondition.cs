using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents a condition that checks for specific products in a promotion.
    /// </summary>
    public class ProductCondition : Condition<ProductComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductCondition"/> with an empty list of values.
        /// </summary>
        public ProductCondition()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="ProductCondition"/> with the specified values.
        /// </summary>
        /// <param name="values"></param>
        public ProductCondition(IEnumerable<string> values)
            : base(ProductComparator.IsEqual)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductCondition"/> with the specified value.
        /// </summary>
        /// <param name="value"></param>
        public ProductCondition(string value)
            : this(new[] { value })
        { }

        /// <summary>
        /// Creates a new instance of <see cref="ProductCondition"/> with the specified values and operator.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        public ProductCondition(IEnumerable<string> values, ProductComparator @operator)
            : base(@operator)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductCondition"/> with the specified value and operator.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        public ProductCondition(string value, ProductComparator @operator)
            : this(new[] { value }, @operator)
        { }

        /// <summary>
        /// List of product IDs to check against.
        /// </summary>
        [XmlElement("product-id")]
        public List<string> Values { get; set; } = new();
    }
}
