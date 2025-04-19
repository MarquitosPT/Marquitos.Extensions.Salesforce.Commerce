using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Simple;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a product discount
    /// </summary>
    [XmlInclude(typeof(SimpleProductDiscount))]
    [XmlInclude(typeof(TieredProductDiscounts))]
    //[XmlInclude(typeof(BogoProductDiscount))]
    //[XmlInclude(typeof(TieredBogoProductDiscounts))]
    //[XmlInclude(typeof(TotalPriceDiscounts))]
    public abstract class PromotionDiscount 
    {
    }
}
