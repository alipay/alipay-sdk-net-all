using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePromotionCouponCreateResponse.
    /// </summary>
    public class AlipayTradePromotionCouponCreateResponse : AopResponse
    {
        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlElement("coupon_info")]
        public PromotionCoupon CouponInfo { get; set; }
    }
}
