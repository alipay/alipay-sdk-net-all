using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveContentRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LiveContentRiskInfo : AopObject
    {
        /// <summary>
        /// 当前规则命中的风险详情信息，譬如风险在图片的坐标、位置信息,坐标对应文字。
        /// </summary>
        [XmlElement("risk_infos")]
        public string RiskInfos { get; set; }

        /// <summary>
        /// 枚举值：HIGH:高；MID:中；LOW：低
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险提示信息
        /// </summary>
        [XmlElement("risk_tips")]
        public string RiskTips { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }
    }
}
