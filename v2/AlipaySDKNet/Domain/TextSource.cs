using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextSource Data Structure.
    /// </summary>
    [Serializable]
    public class TextSource : AopObject
    {
        /// <summary>
        /// 文本来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 文本信息
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
