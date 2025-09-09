using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseOudefinitionCodeQueryResponse.
    /// </summary>
    public class AnttechOceanbaseOudefinitionCodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 2088xx1131，2088账户
        /// </summary>
        [XmlElement("alipay_virtual_id")]
        public string AlipayVirtualId { get; set; }

        /// <summary>
        /// 156，人民币
        /// </summary>
        [XmlElement("base_currency_value")]
        public string BaseCurrencyValue { get; set; }

        /// <summary>
        /// 生效开始时间
        /// </summary>
        [XmlElement("from_effective_date")]
        public string FromEffectiveDate { get; set; }

        /// <summary>
        /// ZN7(澳星贝斯)
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 澳星贝斯-ZN7
        /// </summary>
        [XmlElement("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 156,人民币
        /// </summary>
        [XmlElement("payment_currency_value")]
        public string PaymentCurrencyValue { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [XmlElement("to_effective_date")]
        public string ToEffectiveDate { get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }
    }
}
