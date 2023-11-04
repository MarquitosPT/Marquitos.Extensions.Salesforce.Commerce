using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Represents an price book
    /// </summary>
    public class PriceBook
    {
        /// <summary>
        /// The price book header information
        /// </summary>
        [XmlElement("header")]
        public Header Header { get; set; } = null!;

        /// <summary>
        /// The price book price tables
        /// </summary>
        [XmlElement("price-tables")]
        public PriceTables? PriceTables { get; set; }
    }
}
