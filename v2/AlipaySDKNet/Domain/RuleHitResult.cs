using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleHitResult Data Structure.
    /// </summary>
    [Serializable]
    public class RuleHitResult : AopObject
    {
        /// <summary>
        /// 命中的句子 详情
        /// </summary>
        [XmlArray("hit_dialogues")]
        [XmlArrayItem("hit_dialogue")]
        public List<HitDialogue> HitDialogues { get; set; }

        /// <summary>
        /// 规则命中提示
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 解语花规则配置的风险等级 高中低
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }
    }
}
