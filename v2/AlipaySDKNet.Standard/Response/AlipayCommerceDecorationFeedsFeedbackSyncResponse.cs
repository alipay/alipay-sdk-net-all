using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationFeedsFeedbackSyncResponse.
    /// </summary>
    public class AlipayCommerceDecorationFeedsFeedbackSyncResponse : AopResponse
    {
        /// <summary>
        /// 反馈类型
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }

        /// <summary>
        /// 线索ID
        /// </summary>
        [XmlElement("lead_id")]
        public string LeadId { get; set; }

        /// <summary>
        /// 同步结果描述
        /// </summary>
        [XmlElement("sync_message")]
        public string SyncMessage { get; set; }
    }
}
