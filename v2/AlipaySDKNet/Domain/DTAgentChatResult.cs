using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentChatResult Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentChatResult : AopObject
    {
        /// <summary>
        /// 会话结果内容
        /// </summary>
        [XmlArray("chat_contents")]
        [XmlArrayItem("d_t_agent_chat_content")]
        public List<DTAgentChatContent> ChatContents { get; set; }

        /// <summary>
        /// 单次对话id
        /// </summary>
        [XmlElement("chat_message_id")]
        public string ChatMessageId { get; set; }
    }
}
