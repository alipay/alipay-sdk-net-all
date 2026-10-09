using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmRiskidentifyCertifyResponse.
    /// </summary>
    public class AlipaySecurityRiskReconfirmRiskidentifyCertifyResponse : AopResponse
    {
        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 是否有风险  该字段为风险检测结果，不敏感，无需脱敏
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 风险识别id，为一个标识id，不敏感，无需脱敏
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }
    }
}
