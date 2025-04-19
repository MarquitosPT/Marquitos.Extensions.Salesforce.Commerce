using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a coupon for a promotion in the Salesforce Commerce system.
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Coupon"/> class.
        /// </summary>
        public Coupon()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="Coupon"/> class with the specified coupon ID.
        /// </summary>
        /// <param name="couponID"></param>
        public Coupon(string couponID)
        {
            CouponID = couponID;
        }

        /// <summary>
        /// Coupon ID of the promotion.
        /// </summary>
        [XmlAttribute("coupon-id")]
        public string CouponID { get; set; } = null!;
    }
}
