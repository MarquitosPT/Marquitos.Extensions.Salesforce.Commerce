using Marquitos.Salesforce.Commerce.Models.Promotions.Conditions;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a condition for a condition group.
    /// </summary>
    [XmlInclude(typeof(AttributeCondition))]
    [XmlInclude(typeof(BrandCondition))]
    [XmlInclude(typeof(CategoryCondition))]
    [XmlInclude(typeof(PriceBookCondition))]
    [XmlInclude(typeof(PriceCondition))]
    [XmlInclude(typeof(ProductCondition))]
    public abstract class Condition<TOperator>: Condition where TOperator : Enum
    {
        /// <summary>
        /// Creates a new instance of <see cref="Condition{TOperator}"/> with an empty operator.
        /// </summary>
        protected Condition()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="Condition{TOperator}"/> with the specified operator.
        /// </summary>
        /// <param name="operator"></param>
        protected Condition(TOperator @operator)
        {
            Operator = @operator;
        }

        /// <summary>
        /// Operator for the condition.
        /// </summary>
        [XmlAttribute("operator")]
        public TOperator Operator { get; set; } = default!;
    }

    /// <summary>
    /// Represents a condition for a condition group.
    /// </summary>
    public abstract class Condition
    {
    }
}
