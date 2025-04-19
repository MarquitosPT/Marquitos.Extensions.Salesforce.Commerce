using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    /// <summary>
    /// Represents a collection of custom attributes in the Salesforce Commerce system.
    /// </summary>
    public class CustomAttributes
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class.
        /// </summary>
        public CustomAttributes()
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class with the provided custom attribute values.
        /// </summary>
        /// <param name="values"></param>
        public CustomAttributes(IEnumerable<CustomAttribute> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class with the provided custom attribute values.
        /// </summary>
        /// <param name="values"></param>
        public CustomAttributes(params CustomAttribute[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class with a single custom attribute value.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="value"></param>
        /// <param name="language"></param>
        public CustomAttributes(string attributeID, string value, Language language = Language.Default)
        {
            Values = new() { new CustomAttribute(attributeID, value, language) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class with a single custom attribute value.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="values"></param>
        /// <param name="language"></param>
        public CustomAttributes(string attributeID, IEnumerable<string> values, Language language = Language.Default)
        {
            Values = new() { new CustomAttribute(attributeID, values, language) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomAttributes"/> class with a single custom attribute value.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="language"></param>
        /// <param name="values"></param>
        public CustomAttributes(string attributeID, Language language = Language.Default, params string[] values)
        {
            Values = new() { new CustomAttribute(attributeID, language, values) };
        }

        /// <summary>
        /// List of custom attributes.
        /// </summary>
        [XmlElement("custom-attribute")]
        public List<CustomAttribute> Values { get; set; }
    }
}
