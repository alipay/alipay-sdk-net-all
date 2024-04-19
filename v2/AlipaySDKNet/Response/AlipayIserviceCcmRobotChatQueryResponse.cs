using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotChatQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 机器人问答对话记录
        /// </summary>
        [XmlArray("qa_chats")]
        [XmlArrayItem("q_a_chat_detail")]
        public List<QAChatDetail> QaChats { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
