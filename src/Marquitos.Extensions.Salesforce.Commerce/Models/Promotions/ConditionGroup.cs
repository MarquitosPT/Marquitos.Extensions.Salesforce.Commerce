using Marquitos.Salesforce.Commerce.Models.Promotions.Conditions;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a group of conditions for a promotion.
    /// </summary>
    public class ConditionGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroup"/> with an empty list of conditions.
        /// </summary>
        public ConditionGroup()
        {
            Conditions = new();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroup"/> with the specified conditions.
        /// </summary>
        /// <param name="conditions"></param>
        public ConditionGroup(IEnumerable<Condition> conditions)
        {
            Conditions = new(conditions);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroup"/> with the specified conditions.
        /// </summary>
        /// <param name="conditions"></param>
        public ConditionGroup(params Condition[] conditions)
        {
            Conditions = new(conditions);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroup"/> with the specified condition.
        /// </summary>
        /// <param name="condition"></param>
        public ConditionGroup(Condition condition)
        {
            Conditions = new() { condition };
        }

        /// <summary>
        /// List of conditions in the condition group.
        /// </summary>
        [XmlElement("attribute-condition", Type = typeof(AttributeCondition))]
        [XmlElement("brand-condition", Type = typeof(BrandCondition))]
        [XmlElement("category-condition", Type = typeof(CategoryCondition))]
        //[XmlElement("price-condition", Type = typeof(PriceCondition))]
        [XmlElement("product-id-condition", Type = typeof(ProductCondition))]
        public List<Condition> Conditions { get; set; } 
    }
}
