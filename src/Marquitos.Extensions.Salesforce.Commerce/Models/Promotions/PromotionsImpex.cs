using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// PromotionsImpex class represents the root element of the promotions import/export XML structure.
    /// </summary>
    [XmlRoot("promotions", Namespace = "http://www.demandware.com/xml/impex/promotion/2008-01-31")]
    public class PromotionsImpex
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PromotionsImpex"/> class.
        /// </summary>
        public PromotionsImpex()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionsImpex"/> class with the provided campaigns, promotion settings, promotions, and promotion campaign assignments.
        /// </summary>
        /// <param name="campaigns"></param>
        /// <param name="promotionSettings"></param>
        /// <param name="promotions"></param>
        /// <param name="promotionCampaignAssignments"></param>
        public PromotionsImpex(List<Campaign> campaigns, PromotionSettings? promotionSettings, List<Promotion> promotions, List<PromotionCampaignAssignment> promotionCampaignAssignments)
        {
            Campaigns = campaigns;
            PromotionSettings = promotionSettings;
            Promotions = promotions;
            PromotionCampaignAssignments = promotionCampaignAssignments;
        }

        /// <summary>
        /// List of campaigns.
        /// </summary>
        [XmlElement("campaign")]
        public List<Campaign> Campaigns { get; set; } = new();

        /// <summary>
        /// Global promotion settings for the promotions.
        /// </summary>
        [XmlElement("global-promotion-settings")]
        public PromotionSettings? PromotionSettings { get; set; }

        /// <summary>
        /// List of promotions.
        /// </summary>
        [XmlElement("promotion")]
        public List<Promotion> Promotions { get; set; } = new();

        /// <summary>
        /// List of promotion campaign assignments.
        /// </summary>
        [XmlElement("promotion-campaign-assignment")]
        public List<PromotionCampaignAssignment> PromotionCampaignAssignments { get; set; } = new();
    }
}
