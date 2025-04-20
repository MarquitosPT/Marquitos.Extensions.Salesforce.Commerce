using Marquitos.Salesforce.Commerce.Enums.Conditions;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered
{
    /// <summary>
    /// Represents a collection of tiered product discounts in the Salesforce Commerce system.
    /// </summary>
    public class TieredProductDiscounts : ProductDiscount
    {
        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscounts"/>
        /// </summary>
        public TieredProductDiscounts()
        { }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscounts"/>
        /// </summary>
        /// <param name="discounts"></param>
        /// <param name="conditionType"></param>
        public TieredProductDiscounts(IEnumerable<TieredProductDiscount> discounts, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            Discounts = new(discounts);
            ConditionType = conditionType;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscounts"/>
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="conditionType"></param>
        public TieredProductDiscounts(TieredProductDiscount discount, ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            Discounts = new() { discount };
            ConditionType = conditionType;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TieredProductDiscounts"/>
        /// </summary>
        /// <param name="conditionType"></param>
        public TieredProductDiscounts(ProductPromotionConditionType conditionType = ProductPromotionConditionType.ProductQuantity)
        {
            ConditionType = conditionType;
        }

        /// <summary>
        /// List of tiered product discounts.
        /// </summary>
        [XmlElement("discount")]
        public List<TieredProductDiscount> Discounts { get; set; } = new();

        /// <summary>
        /// The type of condition for the discount.
        /// </summary>
        [XmlAttribute("condition-type")]
        public ProductPromotionConditionType ConditionType { get; set; } = ProductPromotionConditionType.ProductQuantity;
    }
}
