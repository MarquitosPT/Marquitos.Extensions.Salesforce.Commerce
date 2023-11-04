namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Represents a Percentage entry of the price book
    /// </summary>
    public class PercentageEntry : Entry
    {
        /// <summary>
        /// Crestes a new instance
        /// </summary>
        public PercentageEntry()
        {

        }

        /// <summary>
        /// Creates a new instance with the provided value and quantity
        /// </summary>
        /// <param name="value">The percentage value</param>
        /// <param name="quantity">The quantity per value</param>
        public PercentageEntry(decimal value, decimal quantity = 1)
        {
            Value = value;
            Quantity = quantity;
        }
    }
}
