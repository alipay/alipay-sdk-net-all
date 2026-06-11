using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePromotionCouponCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePromotionCouponCreateModel : AopObject
    {
        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlElement("request_info")]
        public PromotionCoupon RequestInfo { get; set; }
    }
}
