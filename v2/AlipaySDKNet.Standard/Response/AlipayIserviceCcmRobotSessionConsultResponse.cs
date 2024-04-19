using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionConsultResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotSessionConsultResponse : AopResponse
    {
        /// <summary>
        /// 机器人答案
        /// </summary>
        [XmlElement("answer")]
        public RobotAnswer Answer { get; set; }

        /// <summary>
        /// DOCUMENT:大模型文档问答； KNOWLEDGE：知识点问答； DST：多轮问答； SORRY：致歉语；
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_uuid")]
        public string ChatUuid { get; set; }

        /// <summary>
        /// 机器人会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
