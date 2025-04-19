using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    /// <summary>
    /// Represents a custom attribute in the Salesforce Commerce system.
    /// </summary>
    public class CustomAttribute
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public CustomAttribute()
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance with the provided parameters
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="value"></param>
        /// <param name="language"></param>
        public CustomAttribute(string attributeID, string value, Language language = Language.Default)
        {
            AttributeID = attributeID;
            Values = new() { value };
            Language = language;
        }

        /// <summary>
        /// Creates a new instance with the provided parameters
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="values"></param>
        /// <param name="language"></param>
        public CustomAttribute(string attributeID, IEnumerable<string> values, Language language = Language.Default)
        {
            AttributeID = attributeID;
            Values = new(values);
            Language = language;
        }

        /// <summary>
        /// Creates a new instance with the provided parameters
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="language"></param>
        /// <param name="values"></param>
        public CustomAttribute(string attributeID, Language language = Language.Default, params string[] values)
        {
            AttributeID = attributeID;
            Language = language;
            Values = new(values);
        }

        /// <summary>
        /// Value of the custom attribute
        /// </summary>
        [XmlElement("value")]
        public List<string> Values { get; set; }

        /// <summary>
        /// Custom attribute ID
        /// </summary>
        [XmlAttribute("attribute-id")]
        public string AttributeID { get; set; } = null!;

        /// <summary>
        /// Language of the custom attribute value
        /// </summary>
        [XmlAttribute("xml:lang"), DefaultValue(typeof(Language), "x-default")]
        public Language Language { get; set; } = Language.Default;
    }
}
