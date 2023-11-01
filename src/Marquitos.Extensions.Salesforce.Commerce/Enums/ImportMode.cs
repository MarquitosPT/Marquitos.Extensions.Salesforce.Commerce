using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Import mode types
    /// </summary>
    public enum ImportMode
    {
        /// <summary>
        /// Delete 
        /// </summary>
        [XmlEnum("delete")]
        Delete
    }
}
