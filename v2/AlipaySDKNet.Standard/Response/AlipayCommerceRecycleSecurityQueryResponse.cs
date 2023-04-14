using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleSecurityQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleSecurityQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单风险评估等级， LOW_RISK：风险较低 HIGH_RISK：风险较高
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 不同风险情况的原因
        /// </summary>
        [XmlElement("risk_reason")]
        public string RiskReason { get; set; }
    }
}
