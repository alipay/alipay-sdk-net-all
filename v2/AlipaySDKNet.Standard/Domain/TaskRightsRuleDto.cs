using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskRightsRuleDto Data Structure.
    /// </summary>
    [Serializable]
    public class TaskRightsRuleDto : AopObject
    {
        /// <summary>
        /// 完成任务后的基础奖励个数
        /// </summary>
        [XmlElement("base_award_count")]
        public long BaseAwardCount { get; set; }

        /// <summary>
        /// 权益规则配置信息
        /// </summary>
        [XmlElement("dynamic_award_config")]
        public TaskRightsRuleDynamicAwardConfigDto DynamicAwardConfig { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("rights_id")]
        public string RightsId { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("rights_name")]
        public string RightsName { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("rule_desc")]
        public string RuleDesc { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则类型 NORMAL("NORMAL", "普通规则"),  DYNAMIC("DYNAMIC", "动态规则"),
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }
    }
}
