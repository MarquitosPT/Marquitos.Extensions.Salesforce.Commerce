using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents the settings for promotions in the Salesforce Commerce system.
    /// </summary>
    public class PromotionSettings
    {
        /// <summary>
        /// Global excluded products for promotions.
        /// </summary>
        [XmlElement("global-excluded-products")]
        public ProductSpecification? GlobalExcludedProducts { get; set; }

        /// <summary>
        /// Global excluded product options for promotions.
        /// </summary>
        [XmlElement("global-excluded-product-options")]
        public ProductOptionSpecification? GlobalExcluedProductOptions { get; set; }

        /// <summary>
        /// Import mode for the settings.
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; } = ImportMode.Delete;
    }
}
