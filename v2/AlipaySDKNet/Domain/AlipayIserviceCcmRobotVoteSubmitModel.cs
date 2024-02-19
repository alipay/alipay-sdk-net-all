using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotVoteSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotVoteSubmitModel : AopObject
    {
        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_uuid")]
        public string ChatUuid { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 对话的评价
        /// </summary>
        [XmlElement("vote_type")]
        public string VoteType { get; set; }
    }
}
