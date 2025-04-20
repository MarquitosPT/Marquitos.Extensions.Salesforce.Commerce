namespace Marquitos.Salesforce.Commerce.Enums.Comparators
{
    /// <summary>
    /// Represents the different comparators that can be used for price book conditions.
    /// </summary>
    public enum PriceBookComparator
    {
        /// <summary>
        /// Compares the storefront price in a recursive manner.
        /// </summary>
        StorefrontPriceInRecursive,

        /// <summary>
        /// Compares the storefront price.
        /// </summary>
        StorefrontPriceIn,

        /// <summary>
        /// Compares the price in a general manner.
        /// </summary>
        PriceIn,
    }
}
