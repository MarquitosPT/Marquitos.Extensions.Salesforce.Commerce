using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a store group for a campain in the Salesforce Commerce system.
    /// </summary>
    public class StoreGroup
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroup"/> class.
        /// </summary>
        public StoreGroup()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroup"/> class with the specified group ID.
        /// </summary>
        /// <param name="groupID"></param>
        public StoreGroup(string groupID)
        {
            GroupID = groupID;
        }

        /// <summary>
        /// Store group ID of the store group.
        /// </summary>
        [XmlAttribute("store-group-id")]
        public string GroupID { get; set; } = null!;
    }
}
