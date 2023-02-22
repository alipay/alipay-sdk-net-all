using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantMsgTemplateLibVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantMsgTemplateLibVO : AopObject
    {
        /// <summary>
        /// 消息母板code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息推送类型，follower为粉丝用户，all为所有用户
        /// </summary>
        [XmlElement("delivery_settings")]
        public string DeliverySettings { get; set; }

        /// <summary>
        /// 消息疲劳度
        /// </summary>
        [XmlElement("fatigue")]
        public MsgFatigueVO Fatigue { get; set; }

        /// <summary>
        /// 是否带push
        /// </summary>
        [XmlElement("has_push")]
        public bool HasPush { get; set; }

        /// <summary>
        /// 行业编码
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 行业场景
        /// </summary>
        [XmlElement("industry_scenario")]
        public string IndustryScenario { get; set; }

        /// <summary>
        /// 关键词描述
        /// </summary>
        [XmlElement("keyword_desc")]
        public string KeywordDesc { get; set; }

        /// <summary>
        /// 消息母板名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于展示母版不可选理由以及具体说明的引导页链接，当模板可选时，本字段为空
        /// </summary>
        [XmlElement("not_selectable_reason")]
        public AccessFailReasonVO NotSelectableReason { get; set; }

        /// <summary>
        /// 描述消息模板为一次性订阅（one_time_subscribe）或长期性订阅（long_term_subscribe）
        /// </summary>
        [XmlElement("scene_rule")]
        public string SceneRule { get; set; }

        /// <summary>
        /// 母板是否可选，若为false，则不可申领
        /// </summary>
        [XmlElement("selectable")]
        public bool Selectable { get; set; }

        /// <summary>
        /// 母板状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
