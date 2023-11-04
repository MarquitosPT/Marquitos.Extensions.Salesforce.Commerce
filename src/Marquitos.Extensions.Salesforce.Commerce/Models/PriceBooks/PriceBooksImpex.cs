using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// The price books import/export model
    /// </summary>
    [XmlRoot("pricebooks", Namespace = "http://www.demandware.com/xml/impex/pricebook/2006-10-31")]
    public class PriceBooksImpex
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public PriceBooksImpex()
        {
            PriceBooks = new List<PriceBook>();
        }

        /// <summary>
        /// Creates a new instance with the provided Price book
        /// </summary>
        /// <param name="priceBook">The price book information</param>
        public PriceBooksImpex(PriceBook priceBook)
        {
            PriceBooks = new List<PriceBook> { priceBook };
        }

        /// <summary>
        /// Creates a new instance with the provided price books collection
        /// </summary>
        /// <param name="values">The price books collection</param>
        public PriceBooksImpex(params PriceBook[] values)
        {
            PriceBooks = new List<PriceBook>(values);
        }

        /// <summary>
        /// Creates a new instance with the provided price books collection
        /// </summary>
        /// <param name="values">The price books collection</param>
        public PriceBooksImpex(IEnumerable<PriceBook> values)
        {
            PriceBooks = new List<PriceBook>(values);
        }

        /// <summary>
        /// The list of containing price books
        /// </summary>
        [XmlElement("pricebook")]
        public List<PriceBook> PriceBooks { get; set; }
    }
}
