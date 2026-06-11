using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePromotionCouponQueryResponse.
    /// </summary>
    public class AlipayTradePromotionCouponQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coupon_list")]
        [XmlArrayItem("promotion_coupon")]
        public List<PromotionCoupon> CouponList { get; set; }
    }
}
