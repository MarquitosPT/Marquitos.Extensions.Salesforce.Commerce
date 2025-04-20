using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Simple;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a product promotion rule.
    /// </summary>
    public class ProductPromotionRule : PromotionRule
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductPromotionRule"/>
        /// </summary>
        public ProductPromotionRule()
        { }

        /// <summary>
        /// Qualifying products
        /// </summary>
        [XmlElement("qualifying-products")]
        public ProductSpecification? QualifyingProducts { get; set; }

        /// <summary>
        /// Discounted products
        /// </summary>
        [XmlElement("discounted-products")]
        public ProductSpecification? DiscountedProducts { get; set; }

        /// <summary>
        /// Qualifying products combination
        /// </summary>
        /// <remarks>This element is present only for product promotions of type "Buy X and Y / Get Z"</remarks>
        [XmlElement("qualifying-products-combination")]
        public ProductCombination? QualifyingProductsCombination { get; set; }

        /// <summary>
        /// Discounted products combination
        /// </summary>
        /// <remarks>This element is present only for product promotions of types "With combination of products" and "Buy X and Y / Get Z"</remarks>
        [XmlElement("discounted-products-combination")]
        public ProductCombination? DiscountedProductsCombination { get; set; }

        /// <summary>
        /// Disable global excluded products
        /// </summary>
        [XmlElement("disable-global-excluded-products"), DefaultValue(false)]
        public bool DisableGlobalExcludedProducts { get; set; }

        /// <summary>
        /// Shipping methods to be used for the promotion.
        /// </summary>
        [XmlElement("shipping-methods")]
        public PromotedShippingMethods? ShippingMethods { get; set; }

        /// <summary>
        /// Payment methods to be used for the promotion.
        /// </summary>
        [XmlElement("payment-methods")]
        public PromotedPaymentMethods? PaymentMethods { get; set; }

        /// <summary>
        /// If set to true, the promotion requires that the qualifying products and discounted products
        /// are all identical.The promotion may apply up to the application limit for each
        /// separate product in the order.
        /// </summary>
        [XmlElement("identical-products"), DefaultValue(false)]
        public bool IdenticalProducts { get; set; }

        /// <summary>
        /// Product discount to be applied to the product.
        /// </summary>
        [XmlElement("simple-discount", Type = typeof(SimpleProductDiscount))]
        [XmlElement("discounts", Type = typeof(TieredProductDiscounts))]
        //[XmlElement("bogo", Type = typeof(BogoProductDiscount))]
        //[XmlElement("bogo-discounts", Type = typeof(TieredBogoProductDiscounts))]
        //[XmlElement("total-discounts", Type = typeof(TotalPriceDiscounts))]
        public ProductDiscount? Discounts { get; set; }

        /// <summary>
        /// The maximum number of times this promotion can be applied to a single product.
        /// </summary>
        [XmlElement("max-applications"), DefaultValue(0)]
        public int MaxApplications { get; set; }
    }
}
