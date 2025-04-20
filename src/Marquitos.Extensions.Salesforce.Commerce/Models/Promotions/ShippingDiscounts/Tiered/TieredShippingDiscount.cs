using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts.Tiered
{
    /// <summary>
    /// Represents a tiered shipping discount in the Salesforce Commerce system.
    /// </summary>
    public class TieredShippingDiscount
    {
        /// <summary>
        /// Creates a new instance of <see cref="TieredShippingDiscount"/> with default values.
        /// </summary>
        public TieredShippingDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="TieredShippingDiscount"/> with the specified discount and threshold.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredShippingDiscount(AmountDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredShippingDiscount"/> with the specified discount and threshold.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredShippingDiscount(FixedPriceDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredShippingDiscount"/> with the specified discount and threshold.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredShippingDiscount(FreeDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredShippingDiscount"/> with the specified discount and threshold.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredShippingDiscount(PercentageDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Threshold for the discount.
        /// </summary>
        [XmlElement("threshold"), DefaultValue(0)]
        public decimal Threshold { get; set; }

        /// <summary>
        /// Discount to be applied when the threshold is met.
        /// </summary>
        [XmlElement("amount", Type = typeof(AmountDiscount))]
        [XmlElement("fixed-price", Type = typeof(FixedPriceDiscount))]
        [XmlElement("free", Type = typeof(FreeDiscount))]
        [XmlElement("percentage", Type = typeof(PercentageDiscount))]
        public Discount Discount { get; set; } = null!;
    }
}
