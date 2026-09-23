using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingInscouponQueryResponse.
    /// </summary>
    public class AlipayInsMarketingInscouponQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coupon_list")]
        [XmlArrayItem("ins_coupon_info")]
        public List<InsCouponInfo> CouponList { get; set; }
    }
}
