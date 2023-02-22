using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomizeRuleResult Data Structure.
    /// </summary>
    [Serializable]
    public class CustomizeRuleResult : AopObject
    {
        /// <summary>
        /// 提交唯一标识，幂等性验证
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则状态
        /// </summary>
        [XmlElement("rule_status")]
        public string RuleStatus { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
