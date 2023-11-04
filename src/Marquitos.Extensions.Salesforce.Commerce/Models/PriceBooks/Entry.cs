using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Represents a generic price table entry
    /// </summary>
    public abstract class Entry
    {
        private decimal _value;

        /// <summary>
        /// The quantity per value
        /// </summary>
        [XmlAttribute("quantity")]
        public decimal Quantity { get; set; } = 1m;

        /// <summary>
        /// The value for the provided quantity
        /// </summary>
        [XmlText]
        public decimal Value { get { return _value; } set { _value = decimal.Parse(value.ToString("N2")); } }
    }
}
