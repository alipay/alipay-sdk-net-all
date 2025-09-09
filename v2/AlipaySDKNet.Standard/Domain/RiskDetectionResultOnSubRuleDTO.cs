using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionResultOnSubRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionResultOnSubRuleDTO : AopObject
    {
        /// <summary>
        /// 检测结果说明
        /// </summary>
        [XmlElement("detection_result_memo")]
        public string DetectionResultMemo { get; set; }

        /// <summary>
        /// 是否阻断
        /// </summary>
        [XmlElement("need_break")]
        public bool NeedBreak { get; set; }

        /// <summary>
        /// 风险判定子规则ID
        /// </summary>
        [XmlElement("risk_judge_sub_rule_id")]
        public string RiskJudgeSubRuleId { get; set; }

        /// <summary>
        /// 风险判定子规则名称
        /// </summary>
        [XmlElement("risk_judge_sub_rule_name")]
        public string RiskJudgeSubRuleName { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险规则ID
        /// </summary>
        [XmlElement("risk_rule_id")]
        public string RiskRuleId { get; set; }

        /// <summary>
        /// 风险判定子规则内容
        /// </summary>
        [XmlElement("sub_rule_content")]
        public string SubRuleContent { get; set; }

        /// <summary>
        /// 风险判定子规则是否匹配成功
        /// </summary>
        [XmlElement("sub_rule_match_sucess")]
        public bool SubRuleMatchSucess { get; set; }
    }
}
