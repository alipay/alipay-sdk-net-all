using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideChatContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideChatContentDTO : AopObject
    {
        /// <summary>
        /// 对话chatId
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 医疗导诊具体会话
        /// </summary>
        [XmlElement("content")]
        public MedicalGuideContentDTO Content { get; set; }

        /// <summary>
        /// 导诊机器人调用耗时(ms)
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
