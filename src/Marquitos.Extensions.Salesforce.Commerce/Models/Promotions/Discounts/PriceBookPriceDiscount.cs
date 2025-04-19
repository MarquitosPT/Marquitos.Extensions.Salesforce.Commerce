using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Discounts
{
    /// <summary>
    /// Represents a discount based on a price book price
    /// </summary>
    public class PriceBookPriceDiscount : Discount
    {
        /// <summary>
        /// Creates a new instance of <see cref="PriceBookPriceDiscount"/>
        /// </summary>
        public PriceBookPriceDiscount()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="PriceBookPriceDiscount"/> with the specified price book ID
        /// </summary>
        /// <param name="priceBookID">The specified price book ID</param>
        public PriceBookPriceDiscount(string priceBookID)
        {
            PriceBookID = priceBookID;
        }

        /// <summary>
        /// Price book identifier
        /// </summary>
        /// <remarks>Generic.NonEmptyString.100</remarks>
        [XmlElement("pricebook-id")]
        public string PriceBookID { get; set; } = null!;
    }
}
