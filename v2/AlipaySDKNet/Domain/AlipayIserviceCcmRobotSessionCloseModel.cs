using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotSessionCloseModel : AopObject
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
