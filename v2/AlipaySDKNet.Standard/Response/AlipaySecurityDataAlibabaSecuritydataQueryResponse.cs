using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataQueryResponse.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 核身校验统计结果,格式为核身校验方式:次数
        /// </summary>
        [XmlElement("identify_result")]
        public string IdentifyResult { get; set; }

        /// <summary>
        /// 用户风险标签，赌博，欺诈，盗用等
        /// </summary>
        [XmlElement("risk_label")]
        public string RiskLabel { get; set; }

        /// <summary>
        /// 风险评分
        /// </summary>
        [XmlElement("risk_score")]
        public string RiskScore { get; set; }
    }
}
