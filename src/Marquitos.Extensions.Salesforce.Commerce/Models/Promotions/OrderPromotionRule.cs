using Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts.Tiered;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a promotion rule that applies to the entire order.
    /// </summary>
    public class OrderPromotionRule : PromotionRule
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

        /// <summary>
        /// Qualifying products
        /// </summary>
        [XmlElement("excluded-products")]
        public ProductSpecification? ExcludedProducts { get; set; }

        /// <summary>
        /// Payment methods to be used for the promotion.
        /// </summary>
        [XmlElement("payment-methods")]
        public PromotedPaymentMethods? PaymentMethods { get; set; }

        /// <summary>
        /// Disable global excluded products
        /// </summary>
        [XmlElement("disable-global-excluded-products"), DefaultValue(false)]
        public bool DisableGlobalExcludedProducts { get; set; }

        /// <summary>
        /// Discount only qualifying products
        /// </summary>
        [XmlElement("discount-only-qualifying-products"), DefaultValue(false)]
        public bool DiscountOnlyQualifyingProducts { get; set; }

        /// <summary>
        /// Order discount to be applied to the order.
        /// </summary>
        [XmlElement("discounts", Type = typeof(TieredOrderDiscounts))]
        public OrderDiscount? Discounts { get; set; }

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
        /// Exclude discounted products from the promotion.
        /// </summary>

        [XmlElement("exclude-discounted-products"), DefaultValue(false)]
        public bool ExcludeDiscountedProducts { get; set; }
    }
}
