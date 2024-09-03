using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatHistory Data Structure.
    /// </summary>
    [Serializable]
    public class ChatHistory : AopObject
    {
        /// <summary>
        /// 针对用户提问的回答
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 用户原始提问
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 单条会话历史的记录唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 提问时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
