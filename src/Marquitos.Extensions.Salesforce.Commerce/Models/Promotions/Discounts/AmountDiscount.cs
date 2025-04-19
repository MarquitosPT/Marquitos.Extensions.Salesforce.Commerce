using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents an amount discount on a product.
    /// </summary>
    public class AmountDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="AmountDiscount"/>.
        /// </summary>
        public AmountDiscount()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="AmountDiscount"/> with the specified amount.
        /// </summary>
        /// <param name="amount">The specified fixed price</param>
        public AmountDiscount(decimal amount)
        {
            Value = amount;
        }

        /// <summary>
        /// The amount to be discounted from the product price.
        /// </summary>
        /// <remarks>Min value 0</remarks>
        [XmlText]
        public decimal Value { get; set; }
    }
}
