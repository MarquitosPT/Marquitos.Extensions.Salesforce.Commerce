using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of stores for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class Stores
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class.
        /// </summary>
        public Stores()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class with the provided store values.
        /// </summary>
        /// <param name="stores"></param>
        public Stores(IEnumerable<Store> stores)
        {
            Values = new(stores);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class with the provided store values.
        /// </summary>
        /// <param name="stores"></param>
        public Stores(params Store[] stores)
        {
            Values = new(stores);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class with a single store id value.
        /// </summary>
        /// <param name="storeID"></param>
        public Stores(string storeID)
        {
            Values = new() { new Store(storeID) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class with a list of store id values.
        /// </summary>
        /// <param name="storeIDs"></param>
        public Stores(IEnumerable<string> storeIDs)
            : this()
        {
            foreach (var storeID in storeIDs)
            {
                Values.Add(new Store(storeID));
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Stores"/> class with a list of store id values.
        /// </summary>
        /// <param name="storeIDs"></param>
        public Stores(params string[] storeIDs)
            : this()
        {
            foreach (var storeID in storeIDs)
            {
                Values.Add(new Store(storeID));
            }
        }

        /// <summary>
        /// List of stores.
        /// </summary>
        [XmlElement("store")]
        public List<Store> Values { get; set; } = new();
    }
}
