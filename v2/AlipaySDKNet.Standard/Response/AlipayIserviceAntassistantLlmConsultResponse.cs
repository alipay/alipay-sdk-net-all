using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceAntassistantLlmConsultResponse.
    /// </summary>
    public class AlipayIserviceAntassistantLlmConsultResponse : AopResponse
    {
        /// <summary>
        /// 当前会话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 当前轮次返回的答案
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }

        /// <summary>
        /// 多轮会话唯一id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
