using Marquitos.Salesforce.Commerce.Enums.Comparators;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents a condition based on product categories for a promotion.
    /// </summary>
    public class CategoryCondition : Condition<CategoryComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="CategoryCondition"/> with an empty list of values.
        /// </summary>
        public CategoryCondition() 
            : base(CategoryComparator.IsEqual)
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of <see cref="CategoryCondition"/> with the specified values.
        /// </summary>
        /// <param name="values"></param>
        public CategoryCondition(IEnumerable<string> values) 
            : base(CategoryComparator.IsEqual)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CategoryCondition"/> with the specified value.
        /// </summary>
        /// <param name="value"></param>
        public CategoryCondition(string value)
            : this(new[] { value })
        { }

        /// <summary>
        /// Creates a new instance of <see cref="CategoryCondition"/> with the specified values and operator.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        public CategoryCondition(IEnumerable<string> values, CategoryComparator @operator)
            : base(@operator)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CategoryCondition"/> with the specified value and operator.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        public CategoryCondition(string value, CategoryComparator @operator)
            : this(new[] { value }, @operator)
        { }

        /// <summary>
        /// List of category values for the condition.
        /// </summary>
        [XmlElement("category-id")]
        public List<string> Values { get; set; }
    }
}
