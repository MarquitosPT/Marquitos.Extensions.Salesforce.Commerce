using Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts.Tiered;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.OrderDiscounts
{
    /// <summary>
    /// Base class for order discounts.
    /// </summary>
    [XmlInclude(typeof(TieredOrderDiscounts))]
    public abstract class OrderDiscount
    {
    }
}
