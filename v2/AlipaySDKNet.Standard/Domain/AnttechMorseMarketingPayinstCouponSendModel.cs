using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingPayinstCouponSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingPayinstCouponSendModel : AopObject
    {
        /// <summary>
        /// 发券活动的活动id，对应要发放的权益红包
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 手机号加密类型，输入手机号时必填
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 用户的唯一支付宝Id。
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 外部请求号，发券唯一标识，用作幂等控制
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 加密后的手机号，加密类型可通过后续字段确认
        /// </summary>
        [XmlElement("phone_id")]
        public string PhoneId { get; set; }

        /// <summary>
        /// 发券类型，支付宝：ALIPAY
        /// </summary>
        [XmlElement("send_voucher_type")]
        public string SendVoucherType { get; set; }

        /// <summary>
        /// wx用户标识appId#openId。send_voucher_type为WEIXIN_COUPON时才有意义
        /// </summary>
        [XmlElement("weixin_id")]
        public string WeixinId { get; set; }
    }
}
