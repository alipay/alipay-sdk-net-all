using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfcreditcontrolRiskdetectionserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfcreditcontrolRiskdetectionserviceQueryModel : AopObject
    {
        /// <summary>
        /// 风险咨询服务请求
        /// </summary>
        [XmlElement("risk_detection_request")]
        public RiskDetectionRequest RiskDetectionRequest { get; set; }
    }
}
