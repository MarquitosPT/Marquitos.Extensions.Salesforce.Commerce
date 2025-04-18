using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Attribute comparator for conditions in promotions.
    /// </summary>
    public enum AttributeComparator
    {
        /// <summary>
        /// Less than
        /// </summary>
        [XmlEnum("less than")]
        LessThan,

        /// <summary>
        /// Greater than
        /// </summary>
        [XmlEnum("greater than")]
        GreaterThan,

        /// <summary>
        /// Equals
        /// </summary>
        [XmlEnum("equals")]
        Equals,

        /// <summary>
        /// Is not equal
        /// </summary>
        [XmlEnum("is not equal")]
        IsNotEqual,

        /// <summary>
        /// Exists
        /// </summary>
        [XmlEnum("exists")]
        Exists,

        /// <summary>
        /// Does not exist
        /// </summary>
        [XmlEnum("does not exist")]
        DoesNotExist,

        /// <summary>
        /// Starts with
        /// </summary>
        [XmlEnum("starts with")]
        StartsWith,

        /// <summary>
        /// Ends with
        /// </summary>
        [XmlEnum("ends with")]
        EndsWith,

        /// <summary>
        /// Contains
        /// </summary>
        [XmlEnum("contains")]
        Contains,

        /// <summary>
        /// Does not contain
        /// </summary>
        [XmlEnum("does not contain")]
        DoesNotContain
    }
}
