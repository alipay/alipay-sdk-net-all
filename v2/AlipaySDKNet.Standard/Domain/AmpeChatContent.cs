using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeChatContent Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeChatContent : AopObject
    {
        /// <summary>
        /// 返回生成对话
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用户的会话流水，代表用户的一次query
        /// </summary>
        [XmlElement("req_no")]
        public string ReqNo { get; set; }

        /// <summary>
        /// 会话id，代表用户一个完整的会话周期，用户串联用户会话的上下文，需要有过期机制，以避免会话过长。不同sessionId下的会话相互隔离。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
