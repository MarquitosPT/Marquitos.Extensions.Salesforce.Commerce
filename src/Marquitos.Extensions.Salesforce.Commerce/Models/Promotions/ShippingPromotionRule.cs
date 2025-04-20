using Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts.Tiered;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a shipping promotion rule in the Salesforce Commerce system.
    /// </summary>
    public class ShippingPromotionRule : PromotionRule
    {

        /// <summary>
        /// Qualifying products
        /// </summary>
        [XmlElement("qualifying-products")]
        public ProductSpecification? QualifyingProducts { get; set; }

        /// <summary>
        /// Qualifying products combination
        /// </summary>
        /// <remarks>This element is present only for product promotions of type "Buy X and Y / Get Z"</remarks>
        [XmlElement("qualifying-products-combination")]
        public ProductCombination? QualifyingProductsCombination { get; set; }

        //    <xsd:element name = "shipping-methods" type="PromotedShippingMethods" minOccurs="0" maxOccurs="1" />
        //    <xsd:element name = "payment-methods" type="PromotedPaymentMethods" minOccurs="0" maxOccurs="1" />

        /// <summary>
        /// Flag that controls behavior for shipping promotions with qualifying products.
        /// If this flag is true, the promotion does not apply if the shipment contains any nonqualifying products,
        /// even if the purchase conditions are otherwise satisfied.  This is the default behavior if this element
        /// is omitted from the import file.
        /// If this flag is false, the promotion allows nonqualifying products in the shipment.
        /// </summary>
        [XmlElement("prohibit-nonqualifying-products"), DefaultValue(false)]
        public bool ProhibitNonqualifyingProducts { get; set; }

        /// <summary>
        /// Disable global excluded products
        /// </summary>
        [XmlElement("disable-global-excluded-products"), DefaultValue(false)]
        public bool DisableGlobalExcludedProducts { get; set; }

        /// <summary>
        /// Shipping discount to be applied to the order.
        /// </summary>
        [XmlElement("discounts", Type = typeof(TieredShippingDiscounts))]
        public ShippingDiscount? Discounts { get; set; }

        /// <summary>
        /// Enable upsell products for the promotion.
        /// </summary>
        [XmlElement("enable-upsells"), DefaultValue(false)]
        public bool EnableUpsells { get; set; }

        /// <summary>
        /// Upsell products threshold.
        /// </summary>

        [XmlElement("upsell-threshold"), DefaultValue(0)]
        public decimal UpsellThreshold { get; set; }

        /// <summary>
        /// The maximum number of times this promotion can be applied to a single product.
        /// </summary>
        [XmlElement("max-applications"), DefaultValue(0)]
        public int MaxApplications { get; set; }
    }
}
