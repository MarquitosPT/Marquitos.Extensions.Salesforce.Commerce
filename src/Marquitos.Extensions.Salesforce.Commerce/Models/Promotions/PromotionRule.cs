using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a rule that defines the behavior of a promotion.
    /// </summary>
    [XmlInclude(typeof(ProductPromotionRule))]
    [XmlInclude(typeof(OrderPromotionRule))]
    public abstract class PromotionRule
    {
    }
}
