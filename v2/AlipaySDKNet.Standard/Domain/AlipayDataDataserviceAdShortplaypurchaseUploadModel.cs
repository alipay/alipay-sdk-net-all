using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdShortplaypurchaseUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdShortplaypurchaseUploadModel : AopObject
    {
        /// <summary>
        /// 短剧小程序appid
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 短剧剧集id
        /// </summary>
        [XmlElement("drama_id")]
        public string DramaId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 付费时间
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 剧集支付金额， 人民币，单位“分”
        /// </summary>
        [XmlElement("shortplay_amount")]
        public string ShortplayAmount { get; set; }

        /// <summary>
        /// 短剧链接
        /// </summary>
        [XmlElement("shortplay_link")]
        public string ShortplayLink { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trans_number")]
        public string TransNumber { get; set; }

        /// <summary>
        /// 短剧购买用户支付宝2088id
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
