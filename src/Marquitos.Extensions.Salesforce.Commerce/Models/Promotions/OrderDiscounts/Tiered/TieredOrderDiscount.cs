using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts.Tiered
{
    /// <summary>
    /// Represents a tiered order discount in the Salesforce Commerce system.
    /// </summary>
    public class TieredOrderDiscount
    {
        /// <summary>
        /// Creates a new instance of <see cref="TieredOrderDiscount"/>
        /// </summary>
        public TieredOrderDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="TieredOrderDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredOrderDiscount(AmountDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredOrderDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredOrderDiscount(BonusDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredOrderDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredOrderDiscount(BonusChoiceDiscount discount, decimal threshold = 0)
        {
            Discount = discount;
            Threshold = threshold;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredOrderDiscount"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        public TieredOrderDiscount(PercentageDiscount discount, decimal threshold = 0)
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
        [XmlElement("bonus", Type = typeof(BonusDiscount))]
        [XmlElement("bonus-choice", Type = typeof(BonusChoiceDiscount))]
        [XmlElement("percentage", Type = typeof(PercentageDiscount))]
        public Discount Discount { get; set; } = null!;
    }
}
