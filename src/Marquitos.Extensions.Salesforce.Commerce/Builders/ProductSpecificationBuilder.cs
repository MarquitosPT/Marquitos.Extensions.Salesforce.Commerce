using Marquitos.Salesforce.Commerce.Models.Promotions;

namespace Marquitos.Salesforce.Commerce.Builders
{
    /// <summary>
    /// Provides a fluent interface for building <see cref="ProductSpecification"/> objects.
    /// </summary>
    public class ProductSpecificationBuilder
    {
        private ProductSpecification productSpecification;

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with an empty <see cref="ProductSpecification"/>.
        /// </summary>
        public ProductSpecificationBuilder()
        {
            productSpecification = new ProductSpecification();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with the specified <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="existent"></param>
        public ProductSpecificationBuilder(ProductSpecification existent)
        {
            ArgumentNullException.ThrowIfNull(existent);

            productSpecification = existent;
        }

        /// <summary>
        /// Sets the included products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithIncludedProducts(ConditionGroups includedProducts)
        {
            productSpecification.IncludedProducts = includedProducts;
            return this;
        }

        /// <summary>
        /// Sets the excluded products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithExcludedProducts(ConditionGroups excludedProducts)
        {
            productSpecification.ExcludedProducts = excludedProducts;
            return this;
        }

        /// <summary>
        /// Sets the included products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithIncludedProducts(params ConditionGroup[] includedProducts)
        {
            productSpecification.IncludedProducts = new ConditionGroups(includedProducts);
            return this;
        }

        /// <summary>
        /// Sets the excluded products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithExcludedProducts(params ConditionGroup[] excludedProducts)
        {
            productSpecification.ExcludedProducts = new ConditionGroups(excludedProducts);
            return this;
        }

        /// <summary>
        /// Sets the included products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithIncludedProducts(IEnumerable<ConditionGroup> includedProducts)
        {
            productSpecification.IncludedProducts = new ConditionGroups(includedProducts);
            return this;
        }

        /// <summary>
        /// Sets the excluded products for the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder WithExcludedProducts(IEnumerable<ConditionGroup> excludedProducts)
        {
            productSpecification.ExcludedProducts = new ConditionGroups(excludedProducts);
            return this;
        }

        /// <summary>
        /// Adds an included product to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProduct"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddIncludedProducts(ConditionGroup includedProduct)
        {
            if (productSpecification.IncludedProducts == null)
            {
                productSpecification.IncludedProducts = new ConditionGroups();
            }
            productSpecification.IncludedProducts.Add(includedProduct);
            return this;
        }

        /// <summary>
        /// Adds an excluded product to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProduct"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddExcludedProducts(ConditionGroup excludedProduct)
        {
            if (productSpecification.ExcludedProducts == null)
            {
                productSpecification.ExcludedProducts = new ConditionGroups();
            }
            productSpecification.ExcludedProducts.Add(excludedProduct);
            return this;
        }

        /// <summary>
        /// Adds included products to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddIncludedProducts(params ConditionGroup[] includedProducts)
        {
            if (productSpecification.IncludedProducts == null)
            {
                productSpecification.IncludedProducts = new ConditionGroups();
            }
            foreach (var includedProduct in includedProducts)
            {
                productSpecification.IncludedProducts.Add(includedProduct);
            }
            return this;
        }

        /// <summary>
        /// Adds excluded products to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddExcludedProducts(params ConditionGroup[] excludedProducts)
        {
            if (productSpecification.ExcludedProducts == null)
            {
                productSpecification.ExcludedProducts = new ConditionGroups();
            }
            foreach (var excludedProduct in excludedProducts)
            {
                productSpecification.ExcludedProducts.Add(excludedProduct);
            }
            return this;
        }

        /// <summary>
        /// Adds included products to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddIncludedProducts(IEnumerable<ConditionGroup> includedProducts)
        {
            if (productSpecification.IncludedProducts == null)
            {
                productSpecification.IncludedProducts = new ConditionGroups();
            }
            foreach (var includedProduct in includedProducts)
            {
                productSpecification.IncludedProducts.Add(includedProduct);
            }
            return this;
        }

        /// <summary>
        /// Adds excluded products to the <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public ProductSpecificationBuilder AddExcludedProducts(IEnumerable<ConditionGroup> excludedProducts)
        {
            if (productSpecification.ExcludedProducts == null)
            {
                productSpecification.ExcludedProducts = new ConditionGroups();
            }
            foreach (var excludedProduct in excludedProducts)
            {
                productSpecification.ExcludedProducts.Add(excludedProduct);
            }
            return this;
        }

        /// <summary>
        /// Builds the <see cref="ProductSpecification"/> object.
        /// </summary>
        /// <returns></returns>
        public ProductSpecification Build()
        {
            return productSpecification;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with default values.
        /// </summary>
        /// <returns></returns>
        public static ProductSpecificationBuilder Create()
        {
            return new ProductSpecificationBuilder();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with the specified included and excluded products.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public static ProductSpecificationBuilder Create(ConditionGroups includedProducts, ConditionGroups excludedProducts)
        {
            return new ProductSpecificationBuilder()
                .WithIncludedProducts(includedProducts)
                .WithExcludedProducts(excludedProducts);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with the specified included and excluded products.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public static ProductSpecificationBuilder Create(ConditionGroup includedProducts, ConditionGroup excludedProducts)
        {
            return new ProductSpecificationBuilder()
                .WithIncludedProducts(includedProducts)
                .WithExcludedProducts(excludedProducts);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecificationBuilder"/> with the specified included and excluded products.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <param name="excludedProducts"></param>
        /// <returns></returns>
        public static ProductSpecificationBuilder Create(IEnumerable<ConditionGroup> includedProducts, IEnumerable<ConditionGroup> excludedProducts)
        {
            return new ProductSpecificationBuilder()
                .WithIncludedProducts(includedProducts)
                .WithExcludedProducts(excludedProducts);
        }

        /// <summary>
        /// Implicitly converts a <see cref="ProductSpecificationBuilder"/> to a <see cref="ProductSpecification"/>.
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator ProductSpecification(ProductSpecificationBuilder builder)
        {
            return builder.Build();
        }

        /// <summary>
        /// Implicitly converts a <see cref="ProductSpecification"/> to a <see cref="ProductSpecificationBuilder"/>.
        /// </summary>
        /// <param name="existent"></param>
        public static implicit operator ProductSpecificationBuilder(ProductSpecification existent)
        {
            return new ProductSpecificationBuilder(existent);
        }
    }
}
