using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents an fixed price discount on a product.
    /// </summary>
    public class FixedPriceDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="FixedPriceDiscount"/>.
        /// </summary>
        public FixedPriceDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="FixedPriceDiscount"/> with the specified fixed price to be applied to the product.
        /// </summary>
        /// <param name="fixedPrice">The fixed price to be applied to the product.</param>
        public FixedPriceDiscount(decimal fixedPrice)
        {
            Value = fixedPrice;
        }

        /// <summary>
        /// The fixed price to be applied to the product.
        /// </summary>
        /// <remarks>Min value 0</remarks>
        [XmlText]
        public decimal Value { get; set; }
    }
}
