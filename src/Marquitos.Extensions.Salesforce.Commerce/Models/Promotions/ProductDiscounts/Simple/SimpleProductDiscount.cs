using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Simple
{
    /// <summary>
    /// Represents a simple product discount that is applied to the promotion
    /// </summary>
    public class SimpleProductDiscount : ProductDiscount
    {
        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/>
        /// </summary>
        public SimpleProductDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified amount discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(AmountDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified bonus discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(BonusDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified bonus choice discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(BonusChoiceDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified fixed price discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(FixedPriceDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified fixed price shipping discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(FixedPriceShippingDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified percentage discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(PercentageDiscount discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimpleProductDiscount"/> with the specified price book price discount.
        /// </summary>
        /// <param name="discount"></param>
        public SimpleProductDiscount(PriceBookPriceDiscount discount)
        {
            Discount = discount;
        }

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
