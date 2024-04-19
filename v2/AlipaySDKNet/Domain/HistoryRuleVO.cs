using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HistoryRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class HistoryRuleVO : AopObject
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("last_modified_time")]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// 模块code
        /// </summary>
        [XmlElement("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 对客产品code
        /// </summary>
        [XmlElement("outer_product_code")]
        public string OuterProductCode { get; set; }

        /// <summary>
        /// 规则子表达式
        /// </summary>
        [XmlElement("rule_conditions")]
        public string RuleConditions { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
