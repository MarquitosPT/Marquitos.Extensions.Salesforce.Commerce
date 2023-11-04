using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Represents a list of price tables
    /// </summary>
    public class PriceTables
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public PriceTables()
        {
            Items = new List<PriceTable>();
        }

        /// <summary>
        /// Creates a new instance with the provided price tables collection
        /// </summary>
        /// <param name="values"></param>
        public PriceTables(IEnumerable<PriceTable> values)
        {
            Items = new List<PriceTable>(values);
        }

        /// <summary>
        /// List os the containing price tables
        /// </summary>
        [XmlElement("price-table")]
        public List<PriceTable> Items { get; set; }
    }
}
