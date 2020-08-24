using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayMerchantauthtokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayMerchantauthtokenGetModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 支付宝合作伙伴id
        /// </summary>
        [XmlElement("partner_owned_merchant_identifier")]
        public string PartnerOwnedMerchantIdentifier { get; set; }

        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// applePay通用请求头
        /// </summary>
        [XmlElement("request_header")]
        public OpenApiAppleRequestHeader RequestHeader { get; set; }

        /// <summary>
        /// wagu公交交易完成后通知标识，由wagu指定，并在交易完成后通知wagu时携带此参数
        /// </summary>
        [XmlElement("transaction_notification_identifier")]
        public string TransactionNotificationIdentifier { get; set; }
    }
}
