using Marquitos.Salesforce.Commerce.Enums;
using Marquitos.Salesforce.Commerce.Models.Shared;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// The price book header information
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Header()
        {
            PriceBookID = string.Empty;
            ImportMode = ImportMode.Delete;
            Currency = "EUR";
            OnlineFrom = new DateTime(1900, 1, 1);
            OnlineTo = new DateTime(9999, 12, 31, 23, 59, 59);
        }

        /// <summary>
        /// Creates a new instance with the provided parameters
        /// </summary>
        /// <param name="priceBookID"></param>
        /// <param name="displayName"></param>
        /// <param name="onlineFlag"></param>
        /// <param name="onlineFrom"></param>
        public Header(string priceBookID, string displayName, bool onlineFlag, DateTime onlineFrom)
            : this(priceBookID, displayName, onlineFlag, onlineFrom, new DateTime(9999, 12, 31, 23, 59, 59))
        { }

        /// <summary>
        /// Creates a new instance with the provided parameters
        /// </summary>
        /// <param name="priceBookID"></param>
        /// <param name="displayName"></param>
        /// <param name="onlineFlag"></param>
        /// <param name="onlineFrom"></param>
        /// <param name="onlineTo"></param>
        public Header(string priceBookID, string displayName, bool onlineFlag, DateTime onlineFrom, DateTime onlineTo)
        {
            PriceBookID = priceBookID;
            ImportMode = ImportMode.Delete;
            Currency = "EUR";
            DisplayName = new LocalizedStrings(displayName);
            OnlineFlag = onlineFlag;
            OnlineFrom = onlineFrom;
            OnlineTo = onlineTo;
        }

        /// <summary>
        /// Price book Identification Key
        /// </summary>
        [XmlAttribute("pricebook-id")]
        public string PriceBookID { get; set; }

        /// <summary>
        /// Import mode
        /// </summary>
        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; }

        /// <summary>
        /// The currency of the price book
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The price book display name in multiple langagues
        /// </summary>
        [XmlElement("display-name")]
        public LocalizedStrings? DisplayName { get; set; }

        /// <summary>
        /// The price book description in multiple languages
        /// </summary>
        [XmlElement("description")]
        public LocalizedStrings? Description { get; set; }

        /// <summary>
        /// Indicates if the price book is online
        /// </summary>
        [XmlElement("online-flag"), DefaultValue(typeof(bool), "false")]
        public bool OnlineFlag { get; set; }

        /// <summary>
        /// The date and time that the price book will go online
        /// </summary>
        [XmlElement("online-from"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime OnlineFrom { get; set; }

        /// <summary>
        /// The date and time that the price book goes offline
        /// </summary>
        [XmlElement("online-to"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime OnlineTo { get; set; }

        /// <summary>
        /// The price book parent identification key
        /// </summary>
        [XmlElement("parent")]
        public string? Parent { get; set; }

        /// <summary>
        /// Indicates if this price book is feed based
        /// </summary>
        [XmlElement("feed-based"), DefaultValue(typeof(bool), "false")]
        public bool FeedBased { get; set; }

        /// <summary>
        /// The price book custom attributes
        /// </summary>
        [XmlElement("custom-attributes")]
        public CustomAttributes? CustomAttributes { get; set; }
    }
}
