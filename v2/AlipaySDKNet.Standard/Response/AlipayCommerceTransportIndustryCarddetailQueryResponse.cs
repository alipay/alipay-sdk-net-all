using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryCarddetailQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryCarddetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡详情
        /// </summary>
        [XmlElement("card")]
        public BizCard Card { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("grant_plan_list")]
        [XmlArrayItem("biz_grant_plan")]
        public List<BizGrantPlan> GrantPlanList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("biz_voucher")]
        public List<BizVoucher> VoucherList { get; set; }
    }
}
