namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    /// <summary>
    /// Represents an Amount entry of price book
    /// </summary>
    public class AmountEntry : Entry
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public AmountEntry()
        {

        }

        /// <summary>
        /// Creates a new intance with the provided value and quantity
        /// </summary>
        /// <param name="value">The amount value</param>
        /// <param name="quantity">The quantity per value</param>
        public AmountEntry(decimal value, decimal quantity = 1)
        {
            Value = value;
            Quantity = quantity;
        }
    }
}
