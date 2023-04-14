using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardUpdateModel : AopObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 扩展信息(暂时无用)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 注意：此字段已废弃，卡面样式以模板中的定义为准。 会员卡卡面展示样式 参考：展示位置详情参考"商家会员卡->快速接入文档->第四步"  备注：mcard_style_info与card_info下的template_id不能同时更新
        /// </summary>
        [XmlElement("mcard_style_info")]
        public McardStylInfo McardStyleInfo { get; set; }

        /// <summary>
        /// 商家会员卡消息信息
        /// </summary>
        [XmlElement("merchant_card_msg_info")]
        public MerchantCardMsgInfo MerchantCardMsgInfo { get; set; }

        /// <summary>
        /// 注意：此字段已废弃。 卡信息变更通知消息 1、在列表中定义的消息，才会发送给用户，消息格式一定。 2、根据卡信息变更情况，一次可发送多个消息
        /// </summary>
        [XmlArray("notify_messages")]
        [XmlArrayItem("mcard_notify_message")]
        public List<McardNotifyMessage> NotifyMessages { get; set; }

        /// <summary>
        /// 标识业务发生时间，时间格式为"yyyy-MM-dd HH:mm:ss"。
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 付费外卡信息，只供特定业务使用，通常接入无需关注
        /// </summary>
        [XmlElement("paid_outer_card_info")]
        public PaidOuterCardExtraInfoDTO PaidOuterCardInfo { get; set; }

        /// <summary>
        /// 支付宝业务卡号，即通过<a href="https://opendocs.alipay.com/apis/009zw3">alipay.marketing.card.open</a>(会员卡开卡)接口开卡后获取的 card_info.biz_card_no 值。
        /// </summary>
        [XmlElement("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型。支持： BIZ_CARD：支付宝业务卡号（商家会员卡场景使用）。
        /// </summary>
        [XmlElement("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
