using Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts.Tiered;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ShippingDiscounts
{
    /// <summary>
    /// Represents a base class for shipping discounts.
    /// </summary>
    [XmlInclude(typeof(TieredShippingDiscounts))]
    public abstract class ShippingDiscount
    {
    }
}
