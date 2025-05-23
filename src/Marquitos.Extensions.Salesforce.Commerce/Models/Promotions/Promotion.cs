﻿using Marquitos.Salesforce.Commerce.Enums;
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

        /// <summary>
        /// The exclusivity of the promotion.
        /// </summary>
        [XmlElement("exclusivity"), DefaultValue(typeof(PromotionExclusivity), "no")]
        public PromotionExclusivity Exclusivity { get; set; } = PromotionExclusivity.No;

        /// <summary>
        /// The exclusivity group of the promotion.
        /// </summary>
        [XmlElement("exclusivity-group")]
        public string? ExclusivityGroup { get; set; }

        /// <summary>
        /// The currency of the promotion
        /// </summary>
        /// <remarks>ISO-4217 3-character currency code</remarks>
        [XmlElement("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// The promotion name in multiple langagues
        /// </summary>
        [XmlElement("name")]
        public LocalizedStrings? Name { get; set; }

        /// <summary>
        /// The promotion callout message in multiple languages
        /// </summary>
        [XmlElement("callout-msg")]
        public LocalizedStrings? CalloutMessage { get; set; }

        /// <summary>
        /// The promotion description in multiple languages
        /// </summary>
        [XmlElement("details")]
        public LocalizedStrings? Details { get; set; }

        /// <summary>
        /// The promotiom image URL
        /// </summary>
        [XmlElement("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Tags associated with the promotion.
        /// </summary>
        [XmlElement("tags")]
        public Tags? Tags { get; set; }

        /// <summary>
        /// List of promotions whether the promotion is combinable.
        /// </summary>
        [XmlElement("combinable-promotions")]
        public CombinablePromotions? CombinablePromotions { get; set; }

        /// <summary>
        /// List of promotions that are mutually exclusive with this promotion.
        /// </summary>
        [XmlElement("mutually-exclusive-promotions")]
        public MutuallyExclusivePromotions? MutuallyExclusivePromotions { get; set; }

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
        [XmlElement("shipping-promotion-rule", Type = typeof(ShippingPromotionRule))]
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
