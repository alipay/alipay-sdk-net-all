using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJobagentSessionInitializeResponse.
    /// </summary>
    public class AlipayEbppJobagentSessionInitializeResponse : AopResponse
    {
        /// <summary>
        /// 初始化后的会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 对话开场白
        /// </summary>
        [XmlElement("welcome_speech")]
        public string WelcomeSpeech { get; set; }
    }
}
