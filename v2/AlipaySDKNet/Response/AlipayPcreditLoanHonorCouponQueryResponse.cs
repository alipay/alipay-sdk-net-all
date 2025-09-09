using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorCouponQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorCouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠券列表（未使用、已使用、已过期）
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_coupon_d_t_o")]
        public List<HonorCouponDTO> Records { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
