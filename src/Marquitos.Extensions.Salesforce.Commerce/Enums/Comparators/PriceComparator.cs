using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums.Comparators
{
    /// <summary>
    /// Enumeration representing different price comparators.
    /// </summary>
    public enum PriceComparator
    {
        /// <summary>
        /// Less than.
        /// </summary>
        [XmlEnum("less than")]
        LessThan,

        /// <summary>
        /// Greater than.
        /// </summary>
        [XmlEnum("greater than")]
        GreaterThan,

        /// <summary>
        /// Ends with.
        /// </summary>
        [XmlEnum("ends with")]
        EndsWith
    }
}
