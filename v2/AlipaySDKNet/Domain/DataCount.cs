using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataCount Data Structure.
    /// </summary>
    [Serializable]
    public class DataCount : AopObject
    {
        /// <summary>
        /// 高亮文本
        /// </summary>
        [XmlElement("highlight_text")]
        public string HighlightText { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
