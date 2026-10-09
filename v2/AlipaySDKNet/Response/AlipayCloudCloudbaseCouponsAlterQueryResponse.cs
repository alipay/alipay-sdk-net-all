using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsAlterQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseCouponsAlterQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠券详情列表
        /// </summary>
        [XmlArray("coupons")]
        [XmlArrayItem("coupon_detail")]
        public List<CouponDetail> Coupons { get; set; }
    }
}
