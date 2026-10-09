using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelFeedbackAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelFeedbackAddModel : AopObject
    {
        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 踩的文本
        /// </summary>
        [XmlArray("feed_back_tags")]
        [XmlArrayItem("string")]
        public List<string> FeedBackTags { get; set; }

        /// <summary>
        /// 点踩反馈值
        /// </summary>
        [XmlElement("feedback")]
        public long Feedback { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
