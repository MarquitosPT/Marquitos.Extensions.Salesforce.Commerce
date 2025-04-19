using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents the assignment of a promotion to a campaign in the Salesforce Commerce system.
    /// </summary>
    public class PromotionCampaignAssignment
    {
        /// <summary>
        /// Qualifiers for the promotion.
        /// </summary>
        [XmlElement("qualifiers")]
        public PromotionQualifiers? PromotionQualifiers { get; set; }

        /// <summary>
        /// The customer groups for the promotion.
        /// </summary>
        [XmlElement("customer-groups")]
        public CustomerGroups? CustomerGroups { get; set; }

        /// <summary>
        /// The coupons for the promotion.
        /// </summary>
        [XmlElement("coupons")]
        public PromotionCoupons? PromotionCoupons { get; set; }

        /// <summary>
        /// The source codes for the promotion.
        /// </summary>
        [XmlElement("source-codes")]
        public PromotionSourceCodeGroups? PromotionSourceCodeGroups { get; set; }

        /// <summary>
        /// The rank of the promotion in the campaign assignment.
        /// </summary>
        /// <remarks>Min 1 inclusive.</remarks>
        [XmlElement("rank"), DefaultValue(1)]
        public int PromotionRank { get; set; } = 1;

        /// <summary>
        /// The promotion schedule for the campaign assignment.
        /// </summary>
        [XmlElement("schedule")]
        public PromotionSchedule? PromotionSchedule { get; set; }

        /// <summary>
        /// Import mode for the promotion campaign assignment.
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; } = ImportMode.Delete;

        /// <summary>
        /// The ID of the promotion to which the campaign is assigned.
        /// </summary>
        [XmlAttribute("promotion-id")]
        public string PromotionID { get; set; } = null!;

        /// <summary>
        /// The ID of the campaign to which the promotion is assigned.
        /// </summary>
        [XmlAttribute("campaign-id")]
        public string CampaignID { get; set; } = null!;
    }
}
