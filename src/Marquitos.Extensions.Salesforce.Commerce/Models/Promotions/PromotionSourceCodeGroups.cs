using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of source code groups for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class PromotionSourceCodeGroups
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class.
        /// </summary>
        public PromotionSourceCodeGroups()
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class with the provided source code group values.
        /// </summary>
        /// <param name="values"></param>
        public PromotionSourceCodeGroups(List<SourceCodeGroup> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class with the provided source code group values.
        /// </summary>
        /// <param name="values"></param>
        public PromotionSourceCodeGroups(params SourceCodeGroup[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class with a single source code group id value.
        /// </summary>
        /// <param name="groupID"></param>
        public PromotionSourceCodeGroups(string groupID)
        {
            Values = new() { new SourceCodeGroup(groupID) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class with a list of source code group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public PromotionSourceCodeGroups(IEnumerable<string> groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new SourceCodeGroup(groupID));
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionSourceCodeGroups"/> class with a list of source code group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public PromotionSourceCodeGroups(params string[] groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new SourceCodeGroup(groupID));
            }
        }

        /// <summary>
        /// List of source code groups to check against.
        /// </summary>
        [XmlElement("source-code")]
        public List<SourceCodeGroup> Values { get; set; }
    }
}
