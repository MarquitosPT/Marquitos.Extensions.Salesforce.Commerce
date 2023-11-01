using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Match mode options
    /// </summary>
    public enum MatchMode
    {
        /// <summary>
        /// Match all
        /// </summary>
        [XmlEnum("all")]
        All,

        /// <summary>
        /// Match any
        /// </summary>
        [XmlEnum("any")]
        Any
    }
}
