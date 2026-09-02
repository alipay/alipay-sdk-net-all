using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class RuleCheckResult : AopObject
    {
        /// <summary>
        /// 枚举：BLOCK（阻断）/WARN（警告）
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 规则内容
        /// </summary>
        [XmlElement("display_text")]
        public string DisplayText { get; set; }

        /// <summary>
        /// 规则标题
        /// </summary>
        [XmlElement("display_title")]
        public string DisplayTitle { get; set; }
    }
}
