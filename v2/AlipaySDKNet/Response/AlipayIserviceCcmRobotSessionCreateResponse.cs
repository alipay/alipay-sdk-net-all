using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotSessionCreateResponse : AopResponse
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
