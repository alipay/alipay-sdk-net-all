using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechDtsparkFeedbackSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechDtsparkFeedbackSubmitModel : AopObject
    {
        /// <summary>
        /// 反馈状态,0表示未反馈,1表示点赞,2表示踩
        /// </summary>
        [XmlElement("feedback_status")]
        public long FeedbackStatus { get; set; }

        /// <summary>
        /// 消息ID，会话中每条消息的唯一ID
        /// </summary>
        [XmlElement("message_id")]
        public long MessageId { get; set; }

        /// <summary>
        /// 会话ID，每次会话会产生唯一ID，根据ID可以获取历史对话记录
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
