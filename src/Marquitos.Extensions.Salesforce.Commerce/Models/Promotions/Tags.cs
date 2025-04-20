using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a list of tags associated with a promotion.
    /// </summary>
    public class Tags
    {
        /// <summary>
        /// Creates a new instance of the Tags class.
        /// </summary>
        public Tags()
        { }

        /// <summary>
        /// Creates a new instance of the Tags class with a single tag.
        /// </summary>
        /// <param name="tag"></param>
        public Tags(string tag)
        {
            Values = new List<string> { tag };
        }

        /// <summary>
        /// Creates a new instance of the Tags class with a list of tags.
        /// </summary>
        /// <param name="tags"></param>
        public Tags(IEnumerable<string> tags)
        {
            Values = new(tags);
        }

        /// <summary>
        /// Creates a new instance of the Tags class with a variable number of tags.
        /// </summary>
        /// <param name="tags"></param>
        public Tags(params string[] tags)
        {
            Values = new(tags);
        }

        /// <summary>
        /// List of tags
        /// </summary>
        /// <remarks>Max length 4000 for each tag.</remarks>
        [XmlElement("tag")]
        public List<string> Values { get; set; } = new();
    }
}
