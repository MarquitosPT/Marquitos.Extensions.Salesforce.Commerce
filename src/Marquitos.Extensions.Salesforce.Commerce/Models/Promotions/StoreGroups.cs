using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of store groups for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class StoreGroups
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class.
        /// </summary>
        public StoreGroups()
        {
            
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class with the provided store group values.
        /// </summary>
        /// <param name="values"></param>
        public StoreGroups(IEnumerable<StoreGroup> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class with the provided store group values.
        /// </summary>
        /// <param name="values"></param>
        public StoreGroups(params StoreGroup[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class with a single store group id value.
        /// </summary>
        /// <param name="groupID"></param>
        public StoreGroups(string groupID)
        {
            Values = new() { new StoreGroup(groupID) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class with a list of store group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public StoreGroups(IEnumerable<string> groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new StoreGroup(groupID));
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="StoreGroups"/> class with a list of store group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public StoreGroups(params string[] groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new StoreGroup(groupID));
            }
        }

        /// <summary>
        /// List of store groups.
        /// </summary>
        [XmlElement("store-group")]
        public List<StoreGroup> Values { get; set; } = new();
    }
}
