using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleMarkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RuleMarkInfo : AopObject
    {
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
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则机审状态，机审通过/机审驳回 ROBOT_PASS/ROBOT_REVIEW_REJECT 来源解语花审核规则查询接口返回的ruleInfo下的status
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
