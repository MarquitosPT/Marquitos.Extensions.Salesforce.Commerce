using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Enumeration for product comparators
    /// </summary>
    public enum ProductComparator
    {
        /// <summary>
        /// The product is equal to the provided value
        /// </summary>
        [XmlEnum("is equal")]
        IsEqual,

        /// <summary>
        /// The product is not equal to the provided value
        /// </summary>
        [XmlEnum("is not equal")]
        IsNotEqual,

        /// <summary>
        /// The product starts with the provided value
        /// </summary>
        [XmlEnum("starts with")]
        StartsWith,

        /// <summary>
        /// The product ends with the provided value
        /// </summary>
        [XmlEnum("ends with")]
        EndsWith,

        /// <summary>
        /// The product contains the provided value
        /// </summary>
        [XmlEnum("contains")]
        Contains,

        /// <summary>
        /// The product does not contain the provided value
        /// </summary>
        [XmlEnum("does not contain")]
        DoesNotContain
    }
}
