using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a rule that defines the behavior of a promotion.
    /// </summary>
    [XmlInclude(typeof(ProductPromotionRule))]
    [XmlInclude(typeof(OrderPromotionRule))]
    [XmlInclude(typeof(ShippingPromotionRule))]
    public abstract class PromotionRule
    {
    }
}
