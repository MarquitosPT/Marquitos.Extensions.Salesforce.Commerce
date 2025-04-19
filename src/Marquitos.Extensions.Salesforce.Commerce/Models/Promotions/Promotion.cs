using Marquitos.Salesforce.Commerce.Enums;
using Marquitos.Salesforce.Commerce.Models.Shared;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a promotion in the Salesforce Commerce system.
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Indicates whether the promotion is enabled.
        /// </summary>
        [XmlElement("enabled-flag"), DefaultValue(false)]
        public bool EnabledFlag { get; set; } = false;

        /// <summary>
        /// Indicates whether the promotion is archived.
        /// </summary>
        [XmlElement("archived-flag"), DefaultValue(false)]
        public bool ArchivedFlag { get; set; } = false;

        /// <summary>
        /// Indicates whether the promotion is searchable.
        /// </summary>
        [XmlElement("searchable-flag"), DefaultValue(false)]
        public bool SearchableFlag { get; set; } = false;

        /// <summary>
        /// Indicates whether the promotion is refinable.
        /// </summary>
        [XmlElement("refinable-flag"), DefaultValue(false)]
        public bool RefinableFlag { get; set; } = false;

        /// <summary>
        /// Indicates whether the promotion should not be requalified.
        /// </summary>
        [XmlElement("prevent-requalifying-flag"), DefaultValue(false)]
        public bool PreventRequalifyingFlag { get; set; } = false;

        /// <summary>
        /// Prorate across eligible items flag. 
        /// </summary>
        [XmlElement("prorate-across-eligible-items-flag"), DefaultValue(false)]
        public bool ProrateAcrossElegibleItemsFlag { get; set; } = false;


        /*
            <xsd:element name="exclusivity" type="PromotionExclusivity" minOccurs="0" maxOccurs="1" />
            <xsd:element name="exclusivity-group" type="Generic.String.256" minOccurs="0" maxOccurs="1" />
            <xsd:element name="currency" type="simpleType.Currency" minOccurs="0" maxOccurs="1" nillable="true" />
            <xsd:element name="name" type="LocalizedString" minOccurs="0" maxOccurs="unbounded" />
            <xsd:element name="callout-msg" type="LocalizedString" minOccurs="0" maxOccurs="unbounded" />
            <xsd:element name="details" type="LocalizedString" minOccurs="0" maxOccurs="unbounded" />
            <xsd:element name="image" type="Generic.String.256" minOccurs="0" maxOccurs="1" />
            <xsd:element name="tags" type="Tags" minOccurs="0" maxOccurs="1" />
            <xsd:element name="combinable-promotions" type="CombinablePromotions" minOccurs="0" maxOccurs="1" />
            <xsd:element name="mutually-exclusive-promotions" type="MutuallyExclusivePromotions" minOccurs="0" maxOccurs="1" />
         */

        /// <summary>
        /// Custom attributes associated with the promotion.
        /// </summary>
        [XmlElement("custom-attributes")]
        public CustomAttributes? CustomAttributes { get; set; }

        /// <summary>
        /// Gets or sets the promotion rule associated with this promotion.
        /// </summary>
        [XmlElement("product-promotion-rule", Type = typeof(ProductPromotionRule))]
        [XmlElement("order-promotion-rule", Type = typeof(OrderPromotionRule))]
        public PromotionRule PromotionRule { get; set; } = null!;

        /// <summary>
        /// Import mode
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; }

        /// <summary>
        /// Promotion ID
        /// </summary>
        [XmlElement("promotion-id")]
        public string PromotionID { get; set; } = string.Empty;
    }
}
