using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotChatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotChatQueryModel : AopObject
    {
        /// <summary>
        /// 聊天窗Code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 访问者ID
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
