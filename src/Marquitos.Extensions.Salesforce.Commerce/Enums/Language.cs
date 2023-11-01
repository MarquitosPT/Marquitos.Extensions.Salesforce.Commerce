using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Language options
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// Default language
        /// </summary>
        [XmlEnum("x-default")]
        Default,

        /// <summary>
        /// English
        /// </summary>
        [XmlEnum("en")]
        English,

        /// <summary>
        /// Portuguese
        /// </summary>
        [XmlEnum("pt")]
        Portuguese,

        /// <summary>
        /// French
        /// </summary>
        [XmlEnum("fr")]
        French,

        /// <summary>
        /// Spanish
        /// </summary>
        [XmlEnum("es")]
        Spanish
    }
}
