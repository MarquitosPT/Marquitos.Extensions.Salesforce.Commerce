namespace Marquitos.Salesforce.Commerce.Enums
{
    /// <summary>
    /// Represents the type of order promotion.
    /// </summary>
    public enum OrderPromotionType
    {
        /// <summary>
        /// Customer must purchase a minimum amount of merchandise to qualify for the discount. 
        /// This is calculated based on the merchandise total for a given order after product promotions have been applied. 
        /// For example, Buy $100 or more, get 10% off.
        /// </summary>
        WithAmountOfQualifyingProducts,

        /// <summary>
        /// Customer must purchase a minimum number of qualifying products to qualify for the discount, 
        /// for example, Buy 3 pair of shoes and get 10% of the merchandise total.
        /// </summary>
        WithNumberOfQualifyingProducts,

        /// <summary>
        /// Customer must purchase a specific combination of products, 
        /// for example, two products from category A and one product from category B in the order to trigger the discount.
        /// </summary>
        WithCombinationOfQualifyingProducts
    }
}
