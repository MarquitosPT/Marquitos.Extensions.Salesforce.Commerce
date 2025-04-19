using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered
{
    /// <summary>
    /// Represents a tiered product discount in the Salesforce Commerce system.
    /// </summary>
    public class TieredProductDiscount
    {
        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        public TieredProductDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(AmountDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(BonusDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(BonusChoiceDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(FixedPriceDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(FixedPriceShippingDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(PercentageDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredProductDiscount(PriceBookPriceDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Threshold for the discount.
        /// </summary>
        [XmlElement("threshold")]
        public decimal Threshold { get; set; }

        /// <summary>
        /// Discount to be applied when the threshold is met.
        /// </summary>
        [XmlElement("amount", Type = typeof(AmountDiscount))]
        [XmlElement("bonus", Type = typeof(BonusDiscount))]
        [XmlElement("bonus-choice", Type = typeof(BonusChoiceDiscount))]
        [XmlElement("fixed-price", Type = typeof(FixedPriceDiscount))]
        [XmlElement("fixed-price-shipping", Type = typeof(FixedPriceShippingDiscount))]
        [XmlElement("percentage", Type = typeof(PercentageDiscount))]
        [XmlElement("price-book-price", Type = typeof(PriceBookPriceDiscount))]
        public Discount Discount { get; set; } = null!;
    }
}
