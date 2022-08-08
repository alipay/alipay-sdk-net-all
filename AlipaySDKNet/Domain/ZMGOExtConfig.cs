using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOExtConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOExtConfig : AopObject
    {
        /// <summary>
        /// 文本内容填充规则ID
        /// </summary>
        [XmlElement("text_content_fill_rule_id")]
        public string TextContentFillRuleId { get; set; }

        /// <summary>
        /// 文本内容填充变量，变量key由运营同学提供
        /// </summary>
        [XmlElement("text_content_fill_variable")]
        public string TextContentFillVariable { get; set; }
    }
}
