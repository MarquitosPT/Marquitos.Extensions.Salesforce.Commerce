using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of customer groups for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class CustomerGroups
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class.
        /// </summary>
        public CustomerGroups()
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class with the provided customer group values.
        /// </summary>
        /// <param name="values"></param>
        public CustomerGroups(IEnumerable<CustomerGroup> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class with the provided customer group values.
        /// </summary>
        /// <param name="values"></param>
        public CustomerGroups(params CustomerGroup[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class with a single customer group id value.
        /// </summary>
        /// <param name="groupID"></param>
        public CustomerGroups(string groupID)
        {
            Values = new() { new CustomerGroup(groupID) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class with a list customer group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public CustomerGroups(IEnumerable<string> groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new CustomerGroup(groupID));
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CustomerGroups"/> class with a list customer group id values.
        /// </summary>
        /// <param name="groupIDs"></param>
        public CustomerGroups(params string[] groupIDs)
            : this()
        {
            foreach (var groupID in groupIDs)
            {
                Values.Add(new CustomerGroup(groupID));
            }
        }

        /// <summary>
        /// List of customer groups to check against.
        /// </summary>
        [XmlElement("customer-group")]
        public List<CustomerGroup> Values { get; set; }

        /// <summary>
        /// Represents the match mode for the customer groups.
        /// Lack of 'MatchMode' attribute defaults to legacy 'any' behavior.
        /// </summary>
        [XmlAttribute("match-mode")]
        public MatchMode MatchMode { get; set; } = MatchMode.Any;
    }
}
