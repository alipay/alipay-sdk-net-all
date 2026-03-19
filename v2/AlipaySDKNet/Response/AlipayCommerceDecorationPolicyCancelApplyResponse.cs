using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationPolicyCancelApplyResponse.
    /// </summary>
    public class AlipayCommerceDecorationPolicyCancelApplyResponse : AopResponse
    {
        /// <summary>
        /// 保司保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 核保状态
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 退保请求流水号
        /// </summary>
        [XmlElement("surrender_flow_no")]
        public string SurrenderFlowNo { get; set; }
    }
}
