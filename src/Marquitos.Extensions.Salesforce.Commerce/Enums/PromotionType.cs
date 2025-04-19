namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Enumeration representing the types of promotions available in Salesforce Commerce.
    /// </summary>
    public enum PromotionType
    {
        /// <summary>
        /// Appliable to product promotions
        /// </summary>
        WithoutQualifyingProducts,

        /// <summary>
        /// Appliable to order, product or shipment promotions
        /// </summary>
        WithAmountOfQualifyingProducts,

        /// <summary>
        /// Appliable to order, product or shipment promotions
        /// </summary>
        WithNumberOfQualifyingProducts,

        /// <summary>
        /// Appliable to order, product or shipment promotions
        /// </summary>
        WithCombinationOfQualifyingProducts
    }
}
