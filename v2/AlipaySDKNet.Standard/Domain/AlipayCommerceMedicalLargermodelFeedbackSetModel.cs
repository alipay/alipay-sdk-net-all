using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelFeedbackSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelFeedbackSetModel : AopObject
    {
        /// <summary>
        /// 行业侧生成，首次为空
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 0：踩 1：赞 -1：取消
        /// </summary>
        [XmlElement("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// ["内容低质","事实错误",....]
        /// </summary>
        [XmlArray("feedback_tags")]
        [XmlArrayItem("string")]
        public List<string> FeedbackTags { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户id，为对外开放新增字段，对外开放时必填。（可以为外部用户ID，同一次陪诊需要传同一个ID）
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 场景Code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
