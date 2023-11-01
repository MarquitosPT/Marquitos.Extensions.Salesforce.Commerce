using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    /// <summary>
    /// Represents a localized string
    /// </summary>
    public class LocalizedString
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public LocalizedString()
        {
            Value = string.Empty;
            Language = Language.Default;
        }

        /// <summary>
        /// Creates a new instance using the provided parameters
        /// </summary>
        /// <param name="value">The string value</param>
        /// <param name="language">The language of the string value</param>
        public LocalizedString(string value, Language language = Language.Default)
        {
            Value = value;
            Language = language;
        }

        /// <summary>
        /// The string value
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        /// <summary>
        /// The language of the string value
        /// </summary>
        [XmlAttribute("xml:lang")]
        public Language Language { get; set; }
    }
}
