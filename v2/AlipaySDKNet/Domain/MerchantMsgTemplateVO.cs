using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantMsgTemplateVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantMsgTemplateVO : AopObject
    {
        /// <summary>
        /// 消息推送类型，follower表示粉丝，all表示全部
        /// </summary>
        [XmlElement("delivery_settings")]
        public string DeliverySettings { get; set; }

        /// <summary>
        /// 消息子板疲劳度
        /// </summary>
        [XmlElement("fatigue")]
        public MsgFatigueVO Fatigue { get; set; }

        /// <summary>
        /// 消息模板关键词列表，关键词之间用逗号隔开
        /// </summary>
        [XmlElement("keyword_desc")]
        public string KeywordDesc { get; set; }

        /// <summary>
        /// 消息子板名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 订阅类型，分为一次性订阅（one_time_subscribe）和长期性订阅（long_term_subscribe）
        /// </summary>
        [XmlElement("scene_rule")]
        public string SceneRule { get; set; }

        /// <summary>
        /// 消息子板状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 消息子板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
