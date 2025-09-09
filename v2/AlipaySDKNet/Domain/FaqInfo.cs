using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaqInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaqInfo : AopObject
    {
        /// <summary>
        /// FAQ问答中的回答
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 扩展问法
        /// </summary>
        [XmlElement("expand")]
        public string Expand { get; set; }

        /// <summary>
        /// FAQ对话中的提问
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }
    }
}
