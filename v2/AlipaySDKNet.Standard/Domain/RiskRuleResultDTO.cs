using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskRuleResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskRuleResultDTO : AopObject
    {
        /// <summary>
        /// 风险事项详情+非唯一
        /// </summary>
        [XmlElement("risk_event")]
        public string RiskEvent { get; set; }

        /// <summary>
        /// 风险等级+非唯一+MEDIUM+LOW+NONE
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险提示+非唯一
        /// </summary>
        [XmlElement("risk_note")]
        public string RiskNote { get; set; }

        /// <summary>
        /// 风险分数+非唯一
        /// </summary>
        [XmlElement("risk_score")]
        public long RiskScore { get; set; }

        /// <summary>
        /// 执行的规则的来源+非唯一+ANT_TREE
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
