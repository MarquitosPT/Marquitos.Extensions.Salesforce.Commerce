using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents the scope of a campaign in the Salesforce Commerce system.
    /// </summary>
    public class CampaignScope
    {
        /// <summary>
        /// Applicable online.
        /// </summary>
        [XmlElement("applicable-online")]
        public EmptyElement? ApplicableOnline { get; set; }

        /// <summary>
        /// Applicable in store.
        /// </summary>
        [XmlElement("applicable-in-store")]
        public EmptyElement? ApplicableInStore { get; set; }
    }
}
