using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseCouponsQueryResponse : AopResponse
    {
        /// <summary>
        /// 全量优惠券列表详情
        /// </summary>
        [XmlArray("coupons")]
        [XmlArrayItem("coupon_detail")]
        public List<CouponDetail> Coupons { get; set; }
    }
}
