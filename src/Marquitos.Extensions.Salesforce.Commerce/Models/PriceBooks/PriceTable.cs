using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Price table
    /// </summary>
    public class PriceTable
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public PriceTable()
        {

        }

        /// <summary>
        /// Creates a new instance with one price entry
        /// </summary>
        /// <param name="productID">The product identification key</param>
        /// <param name="entry">The price entry</param>
        public PriceTable(string productID, Entry entry)
        {
            ProductID = productID;
            Entries = new List<Entry> { entry };
        }

        /// <summary>
        /// Creates a new instance with the provided entries collection
        /// </summary>
        /// <param name="productID">The product identification key</param>
        /// <param name="entries">List of price entries</param>
        public PriceTable(string productID, List<Entry> entries)
        {
            ProductID = productID;
            Entries = entries;
        }

        /// <summary>
        /// The product identification key
        /// </summary>
        [XmlAttribute("product-id")]
        public string ProductID { get; set; } = string.Empty;

        /// <summary>
        /// Import mode
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(PriceTableImportMode), "delete")]
        public PriceTableImportMode ImportMode { get; set; } = PriceTableImportMode.Delete;

        /// <summary>
        /// The date and time that this price table enters online
        /// </summary>
        [XmlElement("online-from"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime OnlineFrom { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// The date and timethat this price table goes offline
        /// </summary>
        [XmlElement("online-to"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime OnlineTo { get; set; } = new DateTime(9999, 12, 31, 23, 59, 59);

        /// <summary>
        /// The list of price entries
        /// </summary>
        [XmlElement("amount", Type = typeof(AmountEntry))]
        [XmlElement("percentage", Type = typeof(PercentageEntry))]
        public List<Entry> Entries { get; set; } = new List<Entry>();

        /// <summary>
        /// Aditional price information
        /// </summary>
        [XmlElement("price-info")]
        public string? PriceInfo { get; set; }
    }
}
