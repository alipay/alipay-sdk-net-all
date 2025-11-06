using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationPolicystatusQueryResponse.
    /// </summary>
    public class AlipayCommerceDecorationPolicystatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 核保状态
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }
    }
}
