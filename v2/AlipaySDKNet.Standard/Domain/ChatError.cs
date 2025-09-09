using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatError Data Structure.
    /// </summary>
    [Serializable]
    public class ChatError : AopObject
    {
        /// <summary>
        /// 流式回答应答码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 未识别到客户意图等之后给出的答案
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
