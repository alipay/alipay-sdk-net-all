using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatChunk Data Structure.
    /// </summary>
    [Serializable]
    public class ChatChunk : AopObject
    {
        /// <summary>
        /// 答案文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
