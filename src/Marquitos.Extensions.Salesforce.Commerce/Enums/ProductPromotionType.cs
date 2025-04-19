namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// The product promotion class supports the following discount types
    /// </summary>
    public enum ProductPromotionType
    {
        /// <summary>
        /// A shopper isn’t required to purchase any qualifying products to qualify for the discount.
        /// For example, buy a brand-A dress, get 10% off the price of the dress
        /// </summary>
        WithoutQualifyingProducts,

        /// <summary>
        /// A shopper must purchase a specific amount (value) of qualifying products to qualify for the discount.
        /// For example, buy $100 worth of a particular brand.
        /// </summary>
        WithAmountOfQualifyingProducts,

        /// <summary>
        /// A shopper must purchase a specific number of qualifying products to qualify for the discount on those products.
        /// For example, buy at least two pairs of jeans.
        /// </summary>
        WithNumberOfQualifyingProducts,

        /// <summary>
        /// A shopper must purchase a specific number of different qualifying products to qualify for the discount on those products.
        /// For example, buy all items in an advertised outfit to receive the discount.
        /// </summary>
        WithCombinationOfQualifyingProducts
    }
}
