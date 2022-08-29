using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityUserQueryvoucherModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityUserQueryvoucherModel : AopObject
    {
        /// <summary>
        /// 活动 id。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式。
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户 PID，默认为当前接口调用商户。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户领取的商家券券码。
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 用户券 id。支付宝为用户优惠券唯一分配的 id。
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
