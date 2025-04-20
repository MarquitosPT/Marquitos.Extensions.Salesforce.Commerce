using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums.Comparators
{
    /// <summary>
    /// Enumeration for brand comparators
    /// </summary>
    public enum BrandComparator
    {
        /// <summary>
        /// The brand exists
        /// </summary>
        [XmlEnum("exists")]
        Exists,

        /// <summary>
        /// The brand does not exist
        /// </summary>
        [XmlEnum("does not exist")]
        DoesNotExist,

        /// <summary>
        /// The brand is equal to the provided value
        /// </summary>
        [XmlEnum("is equal")]
        IsEqual,

        /// <summary>
        /// The brand is not equal to the provided value
        /// </summary>
        [XmlEnum("is not equal")]
        IsNotEqual,

        /// <summary>
        /// The brand starts with the provided value
        /// </summary>
        [XmlEnum("starts with")]
        StartsWith,

        /// <summary>
        /// The brand ends with the provided value
        /// </summary>
        [XmlEnum("ends with")]
        EndsWith,

        /// <summary>
        /// The brand contains the provided value
        /// </summary>
        [XmlEnum("contains")]
        Contains,

        /// <summary>
        /// The brand does not contain the provided value
        /// </summary>
        [XmlEnum("does not contain")]
        DoesNotContain
    }
}
