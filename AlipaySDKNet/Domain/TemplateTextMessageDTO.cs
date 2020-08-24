using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateTextMessageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateTextMessageDTO : AopObject
    {
        /// <summary>
        /// 标签标题文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 模版标签值，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
