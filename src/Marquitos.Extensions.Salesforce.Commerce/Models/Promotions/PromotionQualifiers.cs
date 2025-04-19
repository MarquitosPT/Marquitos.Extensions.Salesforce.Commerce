using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents the qualifiers for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class PromotionQualifiers
    {
        /// <summary>
        /// Customer groups that the promotion applies to.
        /// </summary>
        [XmlElement("customer-groups")]
        public EmptyElement? CustomerGroups { get; set; }

        /// <summary>
        /// Source codes that the promotion applies to.
        /// </summary>
        [XmlElement("source-codes")]
        public EmptyElement? SourceCodes { get; set; }

        /// <summary>
        /// Coupons that the promotion applies to.
        /// </summary>
        [XmlElement("coupons")]
        public EmptyElement? Coupons { get; set; }

        /// <summary>
        /// This attribute determines if all qualifiers must be satisfied in order
        /// for the promotion to be applicable, or if only one must be satisfied.
        /// If not specified during import, then "any" is assumed.
        /// </summary>
        [XmlAttribute("match-mode")]
        public MatchMode MatchMode { get; set; } = MatchMode.Any;
    }
}
