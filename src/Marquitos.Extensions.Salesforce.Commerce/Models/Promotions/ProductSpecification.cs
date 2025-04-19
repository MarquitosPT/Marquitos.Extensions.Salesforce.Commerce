using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a product specification for a promotion.
    /// </summary>
    public class ProductSpecification
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecification"/> with default values.
        /// </summary>
        public ProductSpecification()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="ProductSpecification"/> with the specified included and excluded products.
        /// </summary>
        /// <param name="includedProducts"></param>
        /// <param name="excludedProducts"></param>
        public ProductSpecification(ConditionGroups? includedProducts, ConditionGroups? excludedProducts)
        {
            IncludedProducts = includedProducts;
            ExcludedProducts = excludedProducts;
        }

        /// <summary>
        /// Included products for the promotion.
        /// </summary>
        [XmlArray("included-products")]
        [XmlArrayItem("condition-group")]
        public ConditionGroups? IncludedProducts { get; set; }

        /// <summary>
        /// Excluded products for the promotion.
        /// </summary>
        [XmlArray("excluded-products")]
        [XmlArrayItem("condition-group")]
        public ConditionGroups? ExcludedProducts { get; set; }
    }
}
