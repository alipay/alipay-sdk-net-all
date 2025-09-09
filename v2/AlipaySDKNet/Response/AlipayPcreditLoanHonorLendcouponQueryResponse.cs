using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendcouponQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLendcouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠券列表，按照「可使用 倒序 && 发放时间 倒序」排序优惠券列表。
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
