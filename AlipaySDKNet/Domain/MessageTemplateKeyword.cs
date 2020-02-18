using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MessageTemplateKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class MessageTemplateKeyword : AopObject
    {
        /// <summary>
        /// 颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
