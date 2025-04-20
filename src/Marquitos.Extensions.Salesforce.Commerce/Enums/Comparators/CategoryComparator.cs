using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums.Comparators
{
    /// <summary>
    /// Enumeration for category comparators
    /// </summary>
    public enum CategoryComparator
    {
        /// <summary>
        /// The category is equal to the specified category or any of its child categories.
        /// </summary>
        [XmlEnum("is equal")]
        IsEqual,

        /// <summary>
        /// The category is exactly equal to the specified category.
        /// </summary>
        [XmlEnum("is exactly")]
        IsExactly,

        /// <summary>
        /// The category is a direct child of the specified category.
        /// </summary>
        [XmlEnum("is direct child of")]
        IsDirectChildOf,

        /// <summary>
        /// The category is a child of the specified category.
        /// </summary>
        [XmlEnum("is child of")]
        IsChildOf,

        /// <summary>
        /// The category is a direct parent of the specified category.
        /// </summary>
        [XmlEnum("is direct parent of")]
        IsDirectParentOf,

        /// <summary>
        /// The category is a parent of the specified category.
        /// </summary>
        [XmlEnum("is parent of")]
        IsParentOf,

        /// <summary>
        /// The category is a sibling of the specified category.
        /// </summary>
        [XmlEnum("is sibling of")]
        IsSiblingOf
    }
}
