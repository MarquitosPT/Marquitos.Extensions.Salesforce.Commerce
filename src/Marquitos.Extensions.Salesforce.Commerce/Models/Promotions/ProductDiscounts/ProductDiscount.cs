using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Simple;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts
{
    /// <summary>
    /// Represents a product discount in the Salesforce Commerce system.
    /// </summary>
    [XmlInclude(typeof(SimpleProductDiscount))]
    [XmlInclude(typeof(TieredProductDiscounts))]
    public abstract class ProductDiscount
    {
    }
}
