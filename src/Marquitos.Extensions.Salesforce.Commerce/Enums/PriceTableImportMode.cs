using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Price Table import mode options
    /// </summary>
    public enum PriceTableImportMode
    {
        /// <summary>
        /// Delete existing price tables
        /// </summary>
        [XmlEnum("delete")]
        Delete,

        /// <summary>
        /// Delete all price tables
        /// </summary>
        [XmlEnum("delete-all")]
        DeleteAll
    }
}
