using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a customer group for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class CustomerGroup
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroup"/> class.
        /// </summary>
        public CustomerGroup()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroup"/> class with the specified group ID.
        /// </summary>
        /// <param name="groupID"></param>
        public CustomerGroup(string groupID)
        {
            GroupID = groupID;
        }

        /// <summary>
        /// Group ID of the customer group.
        /// </summary>
        [XmlAttribute("group-id")]
        public string GroupID { get; set; } = null!;
    }
}
