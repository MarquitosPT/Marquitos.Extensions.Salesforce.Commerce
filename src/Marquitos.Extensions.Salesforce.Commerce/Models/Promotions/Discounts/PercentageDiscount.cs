using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a percentage discount on a product.
    /// </summary>
    public class PercentageDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="PercentageDiscount"/>.
        /// </summary>
        public PercentageDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="PercentageDiscount"/> with the specified percentage.
        /// </summary>
        /// <param name="percentage"></param>
        public PercentageDiscount(decimal percentage)
        {
            Value = percentage;
        }

        /// <summary>
        /// The percentage discount to be applied to the product.
        /// </summary>
        /// <remarks>Between 0 and 100</remarks>
        [XmlText]
        public decimal Value { get; set; }
    }
}
