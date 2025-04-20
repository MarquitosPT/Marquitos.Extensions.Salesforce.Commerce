using Marquitos.Salesforce.Commerce.Enums.Conditions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Simple;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;

namespace Marquitos.Salesforce.Commerce.Builders
{
    /// <summary>
    /// Builder class for creating product discount rules.
    /// </summary>
    public class ProductDiscountBuilder
    {
        private ProductDiscount? productDiscount;

        /// <summary>
        /// Creates a new instance of <see cref="ProductDiscountBuilder"/>
        /// </summary>
        public ProductDiscountBuilder()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="ProductDiscountBuilder"/> with the specified simple product discount.
        /// </summary>
        /// <param name="existing"></param>
        public ProductDiscountBuilder(SimpleProductDiscount existing)
        {
            ArgumentNullException.ThrowIfNull(existing);

            productDiscount = existing;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductDiscountBuilder"/> with the specified tiered product discount.
        /// </summary>
        /// <param name="existing"></param>
        public ProductDiscountBuilder(TieredProductDiscounts existing)
        {
            ArgumentNullException.ThrowIfNull(existing);

            productDiscount = existing;
        }

        /// <summary>
        /// Sets the simple product discount for the builder.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleDiscount(SimpleProductDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = discount;
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as an amount discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleAmountDiscount(AmountDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as an amount discount with a specified amount.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleAmountDiscount(decimal amount)
        {
            productDiscount = new SimpleProductDiscount(new AmountDiscount(amount));
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a bonus discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleBonusDiscount(BonusDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a bonus discount with a specified product ID.
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleBonusDiscount(string productID)
        {
            productDiscount = new SimpleProductDiscount(new BonusDiscount(productID));
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a bonus discount with a collection of product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleBonusDiscount(IEnumerable<string> productIDs)
        {
            productDiscount = new SimpleProductDiscount(new BonusDiscount(productIDs));
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a bonus discount with a params array of product IDs.
        /// </summary>
        /// <param name="productIDs"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleBonusDiscount(params string[] productIDs)
        {
            productDiscount = new SimpleProductDiscount(new BonusDiscount(productIDs));
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a bonus choice discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleBonusChoiceDiscount(BonusChoiceDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a fixed price discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleFixedPriceDiscount(FixedPriceDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a fixed price shipping discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimpleFixedPriceShippingDiscount(FixedPriceShippingDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a percentage discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimplePercentageDiscount(PercentageDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the simple product discount for the builder as a price book price discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithSimplePriceBookPriceDiscount(PriceBookPriceDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = new SimpleProductDiscount(discount);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder.
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredDiscounts(TieredProductDiscounts discount)
        {
            ArgumentNullException.ThrowIfNull(discount);
            productDiscount = discount;
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a collection of discounts.
        /// </summary>
        /// <param name="discounts"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredDiscounts(IEnumerable<TieredProductDiscount> discounts, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            ArgumentNullException.ThrowIfNull(discounts);

            productDiscount = new TieredProductDiscounts(discounts, conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredDiscounts(TieredProductDiscount discount, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            ArgumentNullException.ThrowIfNull(discount);

            productDiscount = new TieredProductDiscounts(discount, conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a default condition type.
        /// </summary>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredDiscounts(ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single amount discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredAmountDiscounts(AmountDiscount discount, decimal threshold = 0,ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single bonus discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredBonusDiscounts(BonusDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single bonus choice discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredBonusChoiceDiscounts(BonusChoiceDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single fixed price discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredFixedPriceDiscounts(FixedPriceDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single fixed price shipping discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredFixedPriceShippingDiscounts(FixedPriceShippingDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single percentage discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredPercentageDiscounts(PercentageDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Sets the tiered product discount for the builder with a single price book price discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <param name="conditionType"></param>
        /// <returns></returns>
        public ProductDiscountBuilder WithTieredPriceBookPriceDiscounts(PriceBookPriceDiscount discount, decimal threshold = 0, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            productDiscount = new TieredProductDiscounts(new TieredProductDiscount(discount, threshold), conditionType);
            return this;
        }

        /// <summary>
        /// Adds a tiered amount discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredAmountDiscount(AmountDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);

            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));

            return this;
        }

        /// <summary>
        /// Adds a tiered bonus discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredBonusDiscount(BonusDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Adds a tiered bonus choice discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredBonusChoiceDiscount(BonusChoiceDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Adds a tiered fixed price discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredFixedPriceDiscount(FixedPriceDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Adds a tiered fixed price shipping discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredFixedPriceShippingDiscount(FixedPriceShippingDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Adds a tiered percentage discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredPercentageDiscount(PercentageDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Adds a tiered price book price discount to the product discount.
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscountBuilder AddTieredPriceBookPriceDiscount(PriceBookPriceDiscount discount, decimal threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(productDiscount);
            if (productDiscount is not TieredProductDiscounts tieredProductDiscounts)
            {
                throw new InvalidOperationException("Product discount is not a tiered product discount.");
            }
            tieredProductDiscounts.Discounts.Add(new TieredProductDiscount(discount, threshold));
            return this;
        }

        /// <summary>
        /// Builds the product discount.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public ProductDiscount Build()
        {
            if (productDiscount == null)
            {
                throw new InvalidOperationException("Product discount is not set.");
            }
            return productDiscount;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductDiscountBuilder"/>
        /// </summary>
        /// <returns></returns>
        public static ProductDiscountBuilder Create()
        {
            return new ProductDiscountBuilder();
        }

        /// <summary>
        /// Implicitly converts a <see cref="ProductDiscountBuilder"/> to a <see cref="ProductDiscount"/>.
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator ProductDiscount(ProductDiscountBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            return builder.Build();
        }

        /// <summary>
        /// Implicitly converts a <see cref="SimpleProductDiscount"/> to a <see cref="ProductDiscountBuilder"/>.
        /// </summary>
        /// <param name="discount"></param>
        public static implicit operator ProductDiscountBuilder(SimpleProductDiscount discount)
        {
            ArgumentNullException.ThrowIfNull(discount);

            return new ProductDiscountBuilder(discount);
        }

        /// <summary>
        /// Implicitly converts a <see cref="TieredProductDiscounts"/> to a <see cref="ProductDiscountBuilder"/>.
        /// </summary>
        /// <param name="discount"></param>
        public static implicit operator ProductDiscountBuilder(TieredProductDiscounts discount)
        {
            ArgumentNullException.ThrowIfNull(discount);

            return new ProductDiscountBuilder(discount);
        }
    }
}
