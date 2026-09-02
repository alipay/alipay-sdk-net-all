using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportRailwayCouponQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportRailwayCouponQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coupon_list")]
        [XmlArrayItem("railway_coupon_activity_info")]
        public List<RailwayCouponActivityInfo> CouponList { get; set; }
    }
}
