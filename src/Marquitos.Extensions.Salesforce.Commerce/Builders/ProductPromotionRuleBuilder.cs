using Marquitos.Salesforce.Commerce.Models.Promotions;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts;

namespace Marquitos.Salesforce.Commerce.Builders
{
    /// <summary>
    /// Builder class for creating product promotion rules.
    /// </summary>
    public class ProductPromotionRuleBuilder
    {
        private ProductPromotionRule productPromotionRule;

        /// <summary>
        /// Creates a new instance of <see cref="ProductPromotionRuleBuilder"/>.
        /// </summary>
        public ProductPromotionRuleBuilder()
        {
            productPromotionRule = new ProductPromotionRule();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductPromotionRuleBuilder"/> with an existing <see cref="ProductPromotionRule"/>.
        /// </summary>
        /// <param name="existent"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProductPromotionRuleBuilder(ProductPromotionRule existent)
        {
            ArgumentNullException.ThrowIfNull(existent);

            productPromotionRule = existent;
        }

        /// <summary>
        /// Sets the qualifying products for the promotion rule. 
        /// </summary>
        /// <param name="qualifyingProducts"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithQualifyingProducts(ProductSpecification qualifyingProducts)
        {
            productPromotionRule.QualifyingProducts = qualifyingProducts;
            return this;
        }

        /// <summary>
        /// Sets the discounted products for the promotion rule.
        /// </summary>
        /// <param name="discountedProducts"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithDiscountedProducts(ProductSpecification discountedProducts)
        {
            productPromotionRule.DiscountedProducts = discountedProducts;
            return this;
        }

        /// <summary>
        /// Sets the qualifying products combination for the promotion rule.
        /// </summary>
        /// <param name="qualifyingProductsCombination"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithQualifyingProductsCombination(ProductCombination qualifyingProductsCombination)
        {
            productPromotionRule.QualifyingProductsCombination = qualifyingProductsCombination;
            return this;
        }

        /// <summary>
        /// Sets the discounted products combination for the promotion rule.
        /// </summary>
        /// <param name="discountedProductsCombination"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithDiscountedProductsCombination(ProductCombination discountedProductsCombination)
        {
            productPromotionRule.DiscountedProductsCombination = discountedProductsCombination;
            return this;
        }

        /// <summary>
        /// Sets whether to disable global excluded products for the promotion rule.
        /// </summary>
        /// <param name="disableGlobalExcludedProducts"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithDisableGlobalExcludedProducts(bool disableGlobalExcludedProducts)
        {
            productPromotionRule.DisableGlobalExcludedProducts = disableGlobalExcludedProducts;
            return this;
        }

        /// <summary>
        /// Sets the shipping methods for the promotion rule.
        /// </summary>
        /// <param name="shippingMethods"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithShippingMethods(PromotedShippingMethods shippingMethods)
        {
            productPromotionRule.ShippingMethods = shippingMethods;
            return this;
        }

        /// <summary>
        /// Sets the payment methods for the promotion rule.
        /// </summary>
        /// <param name="paymentMethods"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithPaymentMethods(PromotedPaymentMethods paymentMethods)
        {
            productPromotionRule.PaymentMethods = paymentMethods;
            return this;
        }

        /// <summary>
        /// Sets whether the promotion rule applies to identical products.
        /// </summary>
        /// <param name="identicalProducts"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithIdenticalProducts(bool identicalProducts)
        {
            productPromotionRule.IdenticalProducts = identicalProducts;
            return this;
        }

        /// <summary>
        /// Sets the discounts for the promotion rule.
        /// </summary>
        /// <param name="discounts"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithDiscounts(ProductDiscount discounts)
        {
            productPromotionRule.Discounts = discounts;
            return this;
        }

        /// <summary>
        /// Sets the maximum number of applications for the promotion rule.
        /// </summary>
        /// <param name="maxApplications"></param>
        /// <returns></returns>
        public ProductPromotionRuleBuilder WithMaxApplications(int maxApplications)
        {
            productPromotionRule.MaxApplications = maxApplications;
            return this;
        }

        /// <summary>
        /// Builds and returns the <see cref="ProductPromotionRule"/> instance.
        /// </summary>
        /// <returns></returns>
        public ProductPromotionRule Build()
        {
            return productPromotionRule;
        }

        /// <summary>
        /// Resets the builder to its initial state.
        /// </summary>
        /// <returns></returns>
        public ProductPromotionRuleBuilder Reset()
        {
            productPromotionRule = new ProductPromotionRule();
            return this;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ProductPromotionRuleBuilder"/> class.
        /// </summary>
        /// <returns></returns>
        public static ProductPromotionRuleBuilder Create()
        {
            return new ProductPromotionRuleBuilder();
        }

        /// <summary>
        /// Implicitly converts a <see cref="ProductPromotionRuleBuilder"/> to a <see cref="ProductPromotionRule"/>.
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator ProductPromotionRule(ProductPromotionRuleBuilder builder)
        {
            return builder.Build();
        }

        /// <summary>
        /// Implicitly converts a <see cref="ProductPromotionRule"/> to a <see cref="ProductPromotionRuleBuilder"/>.
        /// </summary>
        /// <param name="existent"></param>
        public static implicit operator ProductPromotionRuleBuilder(ProductPromotionRule existent)
        {
            return new ProductPromotionRuleBuilder(existent);
        }
    }
}
