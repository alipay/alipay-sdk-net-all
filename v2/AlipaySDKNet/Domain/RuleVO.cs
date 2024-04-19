using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class RuleVO : AopObject
    {
        /// <summary>
        /// 模块code
        /// </summary>
        [XmlElement("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 规则条件原始文本
        /// </summary>
        [XmlElement("rule_conditions")]
        public string RuleConditions { get; set; }
    }
}
