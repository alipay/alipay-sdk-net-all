using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardMessageNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardMessageNotifyModel : AopObject
    {
        /// <summary>
        /// 消息通知详情，包含消息通知需要的信息，map 格式存储。 积分过期提醒： <br>expired_point 过期积分值 <br>expired_time 过期时间
        /// </summary>
        [XmlElement("notify_info")]
        public string NotifyInfo { get; set; }

        /// <summary>
        /// 消息通知幂等标识，业务流水号
        /// </summary>
        [XmlElement("notify_no")]
        public string NotifyNo { get; set; }

        /// <summary>
        /// 消息通知类型, <br>POINT_REMIND 积分过期提醒
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 标识业务发生时间，时间格式为"yyyy-MM-dd HH:mm:ss"。
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 支付宝业务卡号，即通过 alipay.marketing.card.open 接口开卡后获取的 card_info.biz_card_no 值。
        /// </summary>
        [XmlElement("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型。支持： BIZ_CARD：支付宝业务卡号（商户会员卡场景使用）。
        /// </summary>
        [XmlElement("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
