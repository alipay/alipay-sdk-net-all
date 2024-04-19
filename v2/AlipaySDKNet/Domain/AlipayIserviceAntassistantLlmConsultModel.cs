using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceAntassistantLlmConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceAntassistantLlmConsultModel : AopObject
    {
        /// <summary>
        /// 用户的提问
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 多轮会话的唯一标识
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }
    }
}
