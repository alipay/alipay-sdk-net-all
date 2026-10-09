using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveFeedbackSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveFeedbackSubmitModel : AopObject
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("feedback_note")]
        public string FeedbackNote { get; set; }

        /// <summary>
        /// 评分，0 非常满意；1 满意 ； 2 一般；3 不满意；5 暂不评价
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 渠道端访客ID
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
