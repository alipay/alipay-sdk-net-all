using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJobagentChatSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJobagentChatSendModel : AopObject
    {
        /// <summary>
        /// 用户输入内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
