using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessCheckItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccessCheckItemInfo : AopObject
    {
        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("access_check")]
        public bool AccessCheck { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 错误提示文案
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }
    }
}
