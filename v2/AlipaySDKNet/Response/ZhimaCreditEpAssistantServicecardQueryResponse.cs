using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantServicecardQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantServicecardQueryResponse : AopResponse
    {
        /// <summary>
        /// 角标跳转链接
        /// </summary>
        [XmlElement("badge_jump_url")]
        public string BadgeJumpUrl { get; set; }

        /// <summary>
        /// 角标通知分类
        /// </summary>
        [XmlElement("badge_notify_type")]
        public string BadgeNotifyType { get; set; }

        /// <summary>
        /// 角标文案
        /// </summary>
        [XmlElement("badge_text")]
        public string BadgeText { get; set; }

        /// <summary>
        /// 角标类型
        /// </summary>
        [XmlElement("badge_type")]
        public string BadgeType { get; set; }

        /// <summary>
        /// 服务按钮文案
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 服务卡片跳转链接，用户引导对应服务落地页
        /// </summary>
        [XmlElement("card_jump_url")]
        public string CardJumpUrl { get; set; }

        /// <summary>
        /// 服务卡片通知数据记录ID，用于回传标记通知已读
        /// </summary>
        [XmlElement("card_notification_id")]
        public string CardNotificationId { get; set; }

        /// <summary>
        /// 服务卡片通知类型
        /// </summary>
        [XmlElement("card_notify_type")]
        public string CardNotifyType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("card_subtitle")]
        [XmlArrayItem("ep_assistant_service_subtitle_segment")]
        public List<EpAssistantServiceSubtitleSegment> CardSubtitle { get; set; }

        /// <summary>
        /// 服务卡片主标题
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 功能引流场景，如 找客户/查企业/盘线索
        /// </summary>
        [XmlElement("guide_scene")]
        public string GuideScene { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("potential_benefits")]
        [XmlArrayItem("string")]
        public List<string> PotentialBenefits { get; set; }
    }
}
