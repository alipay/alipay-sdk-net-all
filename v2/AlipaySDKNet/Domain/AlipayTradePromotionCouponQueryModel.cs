using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePromotionCouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePromotionCouponQueryModel : AopObject
    {
        /// <summary>
        /// 优惠编码
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }
    }
}
