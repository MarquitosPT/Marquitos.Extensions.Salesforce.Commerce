using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents an attribute condition for a promotion.
    /// </summary>
    public class AttributeCondition : Condition<AttributeComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="AttributeCondition"/> with default values.
        /// </summary>
        public AttributeCondition() 
            : base(AttributeComparator.Equals)
        { }

        /// <summary>
        /// Creates a new instance of <see cref="AttributeCondition"/> with the specified attribute ID and values.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="values"></param>
        public AttributeCondition(string attributeID, IEnumerable<string> values)
            : base(AttributeComparator.Equals)
        {
            AttributeID = attributeID;
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AttributeCondition"/> with the specified attribute ID and value.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="value"></param>
        public AttributeCondition(string attributeID, string value)
            : this(attributeID, new[] { value })
        { }

        /// <summary>
        /// Creates a new instance of <see cref="AttributeCondition"/> with the specified attribute ID, values, and operator.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        public AttributeCondition(string attributeID, IEnumerable<string> values, AttributeComparator @operator)
            : base(@operator)
        {
            AttributeID = attributeID;
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AttributeCondition"/> with the specified attribute ID, value, and operator.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        public AttributeCondition(string attributeID, string value, AttributeComparator @operator)
            : this(attributeID, new[] { value }, @operator)
        { }

        /// <summary>
        /// List of values for the condition.
        /// </summary>
        [XmlElement("attribute-value")]
        public List<string> Values { get; set; } = new();


        /// <summary>
        /// Attribute ID for the condition.
        /// </summary>
        [XmlAttribute("attribute-id")]
        public string AttributeID { get; set; } = string.Empty;
    }
}
