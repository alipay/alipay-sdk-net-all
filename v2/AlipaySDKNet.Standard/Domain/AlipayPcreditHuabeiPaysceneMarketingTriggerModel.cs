using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPaysceneMarketingTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPaysceneMarketingTriggerModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId 
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务场景码值，如：飞猪信用住
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 营销渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 事件码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
