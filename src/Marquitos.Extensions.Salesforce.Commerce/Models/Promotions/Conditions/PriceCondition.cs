using Marquitos.Salesforce.Commerce.Enums.Comparators;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions.Conditions
{
    /// <summary>
    /// Represents a condition that checks for specific prices in a promotion.
    /// </summary>
    public class PriceCondition : Condition<PriceComparator>
    {
        /// <summary>
        /// Creates a new instance of <see cref="PriceCondition"/>.
        /// </summary>
        public PriceCondition()
            : base(PriceComparator.LessThan)
        {
            
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriceCondition"/> with the specified price.
        /// </summary>
        /// <param name="price"></param>
        public PriceCondition(decimal price)
            : base(PriceComparator.LessThan)
        {
            Price = price;
        }

        /// <summary>
        /// Creates a new instance of <see cref="PriceCondition"/> with the specified price and operator.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="operator"></param>
        public PriceCondition(decimal price, PriceComparator @operator)
            : base(@operator)
        {
            Price = price;
        }

        /// <summary>
        /// Price
        /// </summary>
        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}
