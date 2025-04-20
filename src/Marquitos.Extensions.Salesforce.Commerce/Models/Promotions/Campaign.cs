using Marquitos.Salesforce.Commerce.Enums;
using Marquitos.Salesforce.Commerce.Models.Shared;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a campaign in the Salesforce Commerce system.
    /// </summary>
    public class Campaign
    {
        /// <summary>
        /// Description of the campaign.
        /// </summary>
        [XmlElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the campaign is enabled.
        /// </summary>
        [XmlElement("enabled-flag"), DefaultValue(false)]
        public bool EnabledFlag { get; set; } = false;

        /// <summary>
        /// Campaign scope.
        /// campaign-scope is part of "DemandwareStore" beta feature. This element will be ignored on import if the feature is not enabled. 
        /// </summary>
        [XmlElement("campaign-scope")]
        public CampaignScope? CampaignScope { get; set; }

        /// <summary>
        /// The start date of the campaign.
        /// </summary>
        [XmlElement("start-date"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime StartDate { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// The end date of the campaign.
        /// </summary>
        [XmlElement("end-date"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime EndDate { get; set; } = new DateTime(9999, 12, 31, 23, 59, 59);

        /// <summary>
        /// Customer groups for the campaign.
        /// </summary>
        [XmlElement("customer-groups")]
        public CustomerGroups? CustomerGroups { get; set; }

        /// <summary>
        /// Coupons for the campaign.
        /// </summary>
        [XmlElement("coupons")]
        public PromotionCoupons? PromotionCoupons { get; set; }

        /// <summary>
        /// Source codes for the campaign.
        /// </summary>
        [XmlElement("source-codes")]
        public PromotionSourceCodeGroups? PromotionSourceCodeGroups { get; set; }

        /// <summary>
        /// Store groups for the campaign.
        /// store-groups are part of "DemandwareStore" beta feature. This element will be ignored on import if the feature is not enabled. 
        /// </summary>
        [XmlElement("store-groups")]
        public StoreGroups? StoreGroups { get; set; }

        /// <summary>
        /// Stores for the campaign.
        /// stores are part of "DemandwareStore" beta feature. This element will be ignored on import if the feature is not enabled.
        /// </summary>
        [XmlElement("stores")]
        public Stores? Stores { get; set; }

        /// <summary>
        /// Custom attributes for the campaign.
        /// </summary>
        [XmlElement("custom-attributes")]
        public CustomAttributes? CustomAttributes { get; set; }

        /// <summary>
        /// Import mode for the campaign.
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; } = ImportMode.Delete;

        /// <summary>
        /// The ID of the campaign.
        /// </summary>
        [XmlAttribute("campaign-id")]
        public string CampaignID { get; set; } = null!;
    }
}
