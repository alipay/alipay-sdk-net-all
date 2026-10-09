using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsOpenQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseCouponsOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠券列表
        /// </summary>
        [XmlArray("coupons")]
        [XmlArrayItem("coupon_detail")]
        public List<CouponDetail> Coupons { get; set; }
    }
}
