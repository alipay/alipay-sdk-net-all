using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneSimplestPolicyApplyResponse.
    /// </summary>
    public class AlipayInsSceneSimplestPolicyApplyResponse : AopResponse
    {
        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 预下单ID
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
