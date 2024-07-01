using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ValidationRule Data Structure.
    /// </summary>
    [Serializable]
    public class ValidationRule : AopObject
    {
        /// <summary>
        /// 0-不支持费控，1-支持费控
        /// </summary>
        [XmlElement("cons_type")]
        public string ConsType { get; set; }

        /// <summary>
        /// 规则校验对应的错误提示 如：户号必须为10位数字
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 最小金额， 单位元
        /// </summary>
        [XmlElement("min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// 正则表达式规则 如十位数字的正则表达式为：^\d{10}$
        /// </summary>
        [XmlElement("rule_text")]
        public string RuleText { get; set; }

        /// <summary>
        /// 复杂类型校验-vObj 正则类型-regexp
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }
    }
}
