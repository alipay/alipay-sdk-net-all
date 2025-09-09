using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleRiskConsultResponse.
    /// </summary>
    public class AlipayCommerceRecycleRiskConsultResponse : AopResponse
    {
        /// <summary>
        /// 风险等级 1～5（分数越小风险越高）
        /// </summary>
        [XmlElement("risk_level")]
        public long RiskLevel { get; set; }
    }
}
