using Marquitos.Salesforce.Commerce.Enums.Comparators;
using Marquitos.Salesforce.Commerce.Models.Promotions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Conditions;

namespace Marquitos.Salesforce.Commerce.Builders
{
    /// <summary>
    /// Builder class for creating condition groups for promotions.
    /// </summary>
    public class ConditionGroupBuilder
    {
        private ConditionGroup conditionGroup;

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with an empty condition group.
        /// </summary>
        public ConditionGroupBuilder()
        {
            conditionGroup = new ConditionGroup();
        }

        /// <summary>
        /// Adds a condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddCondition(Condition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds an attribute condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddAttributeCondition(AttributeCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds an attribute condition to the condition group with the specified attribute ID and value.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="value"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddAttributeCondition(string attributeID, string value, AttributeComparator @operator = AttributeComparator.LessThan)
        {
            conditionGroup.Conditions.Add(new AttributeCondition(attributeID, value, @operator));
            return this;
        }

        /// <summary>
        /// Adds an attribute condition to the condition group with the specified attribute ID and values.
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="values"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddAttributeCondition(string attributeID, IEnumerable<string> values, AttributeComparator @operator = AttributeComparator.LessThan)
        {
            conditionGroup.Conditions.Add(new AttributeCondition(attributeID, values, @operator));
            return this;
        }

        /// <summary>
        /// Adds a brand condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddBrandCondition(BrandCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds a brand condition to the condition group with the specified brand and operator.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddBrandCondition(string brand, BrandComparator @operator = BrandComparator.Exists)
        {
            conditionGroup.Conditions.Add(new BrandCondition(brand, @operator));
            return this;
        }

        /// <summary>
        /// Adds a brand condition to the condition group with the specified brands and operator.
        /// </summary>
        /// <param name="brands"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddBrandCondition(IEnumerable<string> brands, BrandComparator @operator = BrandComparator.Exists)
        {
            conditionGroup.Conditions.Add(new BrandCondition(brands, @operator));
            return this;
        }

        /// <summary>
        /// Adds a category condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddCategoryCondition(CategoryCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds a category condition to the condition group with the specified category ID and operator.
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddCategoryCondition(string categoryID, CategoryComparator @operator = CategoryComparator.IsEqual)
        {
            conditionGroup.Conditions.Add(new CategoryCondition(categoryID, @operator));
            return this;
        }

        /// <summary>
        /// Adds a category condition to the condition group with the specified categories and operator.
        /// </summary>
        /// <param name="categoryIDs"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddCategoryCondition(IEnumerable<string> categoryIDs, CategoryComparator @operator = CategoryComparator.IsEqual)
        {
            conditionGroup.Conditions.Add(new CategoryCondition(categoryIDs, @operator));
            return this;
        }

        /// <summary>
        /// Adds a price book condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddPriceBookCondition(PriceBookCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds a price book condition to the condition group with the specified price book ID and operator.
        /// </summary>
        /// <param name="pricebookID"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddPriceBookCondition(string pricebookID, PriceBookComparator @operator = PriceBookComparator.StorefrontPriceInRecursive)
        {
            conditionGroup.Conditions.Add(new PriceBookCondition(pricebookID, @operator));
            return this;
        }

        /// <summary>
        /// Adds a price book condition to the condition group with the specified price book IDs and operator.
        /// </summary>
        /// <param name="pricebookIDs"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddPriceBookCondition(IEnumerable<string> pricebookIDs, PriceBookComparator @operator = PriceBookComparator.StorefrontPriceInRecursive)
        {
            conditionGroup.Conditions.Add(new PriceBookCondition(pricebookIDs, @operator));
            return this;
        }

        /// <summary>
        /// Adds a price condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddPriceCondition(PriceCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds a price condition to the condition group with the specified price and operator.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddPriceCondition(decimal price, PriceComparator @operator)
        {
            conditionGroup.Conditions.Add(new PriceCondition(price, @operator));
            return this;
        }

        /// <summary>
        /// Adds a product condition to the condition group.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddProductCondition(ProductCondition condition)
        {
            ArgumentNullException.ThrowIfNull(condition);

            conditionGroup.Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds a product condition to the condition group with the specified product ID and operator.
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddProductCondition(string productID, ProductComparator @operator = ProductComparator.IsEqual)
        {
            conditionGroup.Conditions.Add(new ProductCondition(productID, @operator));
            return this;
        }

        /// <summary>
        /// Adds a product condition to the condition group with the specified product IDs and operator.
        /// </summary>
        /// <param name="productIDs"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public ConditionGroupBuilder AddProductCondition(IEnumerable<string> productIDs, ProductComparator @operator = ProductComparator.IsEqual)
        {
            conditionGroup.Conditions.Add(new ProductCondition(productIDs, @operator));
            return this;
        }

        /// <summary>
        /// Adds a list of conditions to the condition group.
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddConditions(IEnumerable<Condition> conditions)
        {
            ArgumentNullException.ThrowIfNull(conditions);

            conditionGroup.Conditions.AddRange(conditions);
            return this;
        }

        /// <summary>
        /// Adds a list of conditions to the condition group.
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionGroupBuilder AddConditions(params Condition[] conditions)
        {
            ArgumentNullException.ThrowIfNull(conditions);

            conditionGroup.Conditions.AddRange(conditions);
            return this;
        }

        /// <summary>
        /// Builds and returns the condition group.
        /// </summary>
        /// <returns></returns>
        public ConditionGroup Build()
        {
            return conditionGroup;
        }

        /// <summary>
        /// Resets the condition group to a new instance.
        /// </summary>
        /// <returns></returns>
        public ConditionGroupBuilder Reset()
        {
            conditionGroup = new ConditionGroup();
            return this;
        }

        /// <summary>
        /// Implicitly converts a <see cref="ConditionGroupBuilder"/> to a <see cref="ConditionGroup"/>.
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator ConditionGroup(ConditionGroupBuilder builder)
        {
            return builder.Build();
        }

        /// <summary>
        /// Implicitly converts a <see cref="ConditionGroup"/> to a <see cref="ConditionGroupBuilder"/>.
        /// </summary>
        /// <param name="conditionGroup"></param>
        public static implicit operator ConditionGroupBuilder(ConditionGroup conditionGroup)
        {
            return Create(conditionGroup);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with an empty condition group.
        /// </summary>
        /// <returns></returns>
        public static ConditionGroupBuilder Create()
        {
            return new ConditionGroupBuilder();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with the specified condition group.
        /// </summary>
        /// <param name="conditionGroup"></param>
        /// <returns></returns>
        public static ConditionGroupBuilder Create(ConditionGroup conditionGroup)
        {
            return new ConditionGroupBuilder()
                .AddConditions(conditionGroup.Conditions);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with the specified condition.
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ConditionGroupBuilder Create(Condition condition)
        {
            return new ConditionGroupBuilder()
                .AddCondition(condition);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with the specified conditions.
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static ConditionGroupBuilder Create(IEnumerable<Condition> conditions)
        {
            return new ConditionGroupBuilder()
                .AddConditions(conditions);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroupBuilder"/> with the specified conditions.
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static ConditionGroupBuilder Create(params Condition[] conditions)
        {
            return new ConditionGroupBuilder()
                .AddConditions(conditions);
        }
    }
}
