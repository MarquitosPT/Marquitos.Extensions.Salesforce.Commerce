using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of coupons for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class PromotionCoupons
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class.
        /// </summary>
        public PromotionCoupons()
        {
            Values = new();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class with the provided coupon values.
        /// </summary>
        /// <param name="values"></param>
        public PromotionCoupons(IEnumerable<Coupon> values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class with the provided coupon values.
        /// </summary>
        /// <param name="values"></param>
        public PromotionCoupons(params Coupon[] values)
        {
            Values = new(values);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class with a single coupon id value.
        /// </summary>
        /// <param name="couponID"></param>
        public PromotionCoupons(string couponID)
        {
            Values = new() { new Coupon(couponID) };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class with a list of coupon id values.
        /// </summary>
        /// <param name="couponIDs"></param>
        public PromotionCoupons(IEnumerable<string> couponIDs)
            : this()
        {
            foreach (var couponID in couponIDs)
            {
                Values.Add(new Coupon(couponID));
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="PromotionCoupons"/> class with a list of coupon id values.
        /// </summary>
        /// <param name="couponIDs"></param>
        public PromotionCoupons(params string[] couponIDs)
            : this()
        {
            foreach (var couponID in couponIDs)
            {
                Values.Add(new Coupon(couponID));
            }
        }

        /// <summary>
        /// List of coupons to check against.
        /// </summary>
        [XmlElement("coupon")]
        public List<Coupon> Values { get; set; }
    }
}
