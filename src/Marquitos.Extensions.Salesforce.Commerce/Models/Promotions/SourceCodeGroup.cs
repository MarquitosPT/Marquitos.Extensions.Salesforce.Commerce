using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a source code group for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class SourceCodeGroup
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SourceCodeGroup"/> class.
        /// </summary>
        public SourceCodeGroup()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="SourceCodeGroup"/> class with the specified group ID.
        /// </summary>
        /// <param name="groupID"></param>
        public SourceCodeGroup(string groupID)
        {
            GroupID = groupID;
        }

        /// <summary>
        /// Group ID of the source code group.
        /// </summary>
        [XmlAttribute("group-id")]
        public string GroupID { get; set; } = null!;
    }
}
