using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextTemplateData Data Structure.
    /// </summary>
    [Serializable]
    public class TextTemplateData : AopObject
    {
        /// <summary>
        /// 文本消息的文字
        /// </summary>
        [XmlElement("m")]
        public string M { get; set; }
    }
}
