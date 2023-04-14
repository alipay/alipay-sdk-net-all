using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RuleInfo : AopObject
    {
        /// <summary>
        /// 规则关注度：BLOCK（阻断）、ATTENTION（提醒）
        /// </summary>
        [XmlElement("attention_level")]
        public string AttentionLevel { get; set; }

        /// <summary>
        /// 机审反馈内容。一般当机审有误时，补充具体机审有误的说明。
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// CORRECT-机审正确；ERROR-机审有误
        /// </summary>
        [XmlElement("mark_result")]
        public string MarkResult { get; set; }

        /// <summary>
        /// 风险等级（高、中、低三类）
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

        /// <summary>
        /// 规则机审状态，机审通过/机审驳回 ROBOT_PASS/ROBOT_REVIEW_REJECT 用于 人工打标规则结果提交 接口中的status传参
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
