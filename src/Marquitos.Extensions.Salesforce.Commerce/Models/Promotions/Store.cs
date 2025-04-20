using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a store in the Salesforce Commerce system.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Default constructor for the Store class.
        /// </summary>
        public Store()
        { }

        /// <summary>
        /// Constructor for the Store class with store ID.
        /// </summary>
        /// <param name="storeID"></param>
        public Store(string storeID)
        {
            StoreID = storeID;
        }

        /// <summary>
        /// The ID of the store.
        /// </summary>
        [XmlElement("store-id")]
        public string StoreID { get; set; } = null!;
    }
}
