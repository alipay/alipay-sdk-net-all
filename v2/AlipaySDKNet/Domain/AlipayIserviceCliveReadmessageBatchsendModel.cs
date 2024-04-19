using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveReadmessageBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveReadmessageBatchsendModel : AopObject
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 已读的消息id集合，UUID
        /// </summary>
        [XmlArray("message_ids")]
        [XmlArrayItem("string")]
        public List<string> MessageIds { get; set; }

        /// <summary>
        /// 已读时间
        /// </summary>
        [XmlElement("read_time")]
        public string ReadTime { get; set; }
    }
}
