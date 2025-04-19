using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Represents the exclusivity of a promotion in the Salesforce Commerce system.
    /// </summary>
    public enum PromotionExclusivity
    {
        /// <summary>
        /// Indicates that the promotion is not exclusive.
        /// </summary>
        [XmlEnum("no")]
        No,

        /// <summary>
        /// Indicates that the promotion is exclusive to a specific class.
        /// </summary>
        [XmlEnum("class")]
        Class,

        /// <summary>
        /// Indicates that the promotion is exclusive globally.
        /// </summary>
        [XmlEnum("global")]
        Global
    }
}
