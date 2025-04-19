using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a fixed price shipping discount for a product.
    /// </summary>
    public class FixedPriceShippingDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="FixedPriceShippingDiscount"/>.
        /// </summary>
        public FixedPriceShippingDiscount()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="FixedPriceShippingDiscount"/> with the specified fixed price.
        /// </summary>
        /// <param name="fixedPrice">The specified fixed price</param>
        public FixedPriceShippingDiscount(decimal fixedPrice)
        {
            Value = fixedPrice;
        }

        /// <summary>
        /// The fixed price for the shipping after the discount is applied.
        /// </summary>
        /// <remarks>Min value 0</remarks>
        [XmlText]
        public decimal Value { get; set; }
    }
}
