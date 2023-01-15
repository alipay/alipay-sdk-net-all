using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityMessageBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityMessageBindModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 支付宝商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户提供的用于接收营销事件通知的小程序ID
        /// </summary>
        [XmlElement("notify_appid")]
        public string NotifyAppid { get; set; }
    }
}
