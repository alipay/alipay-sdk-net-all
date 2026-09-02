using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EliminationRuleDetailItem Data Structure.
    /// </summary>
    [Serializable]
    public class EliminationRuleDetailItem : AopObject
    {
        /// <summary>
        /// 业务标识(能力环节=题目ID,检测环节=检测项编码,收集环节=字段编码)
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 检测指标编码(仅检测环节有值)
        /// </summary>
        [XmlElement("check_metric")]
        public string CheckMetric { get; set; }

        /// <summary>
        /// 规则描述(用于报告展示淘汰原因)
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 淘汰规则唯一标识
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 淘汰结果:NOT_PASS-不通过/PENDING-待定/PASS-通过
        /// </summary>
        [XmlElement("rule_qualified")]
        public string RuleQualified { get; set; }

        /// <summary>
        /// 环节名称
        /// </summary>
        [XmlElement("stage_name")]
        public string StageName { get; set; }
    }
}
