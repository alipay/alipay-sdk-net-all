using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOverviewQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOverviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额(元)
        /// </summary>
        [XmlElement("account_amount_total")]
        public string AccountAmountTotal { get; set; }

        /// <summary>
        /// 可用余额(元)
        /// </summary>
        [XmlElement("format_available_amount_total")]
        public string FormatAvailableAmountTotal { get; set; }

        /// <summary>
        /// 授信(元)
        /// </summary>
        [XmlElement("format_credit_amount")]
        public string FormatCreditAmount { get; set; }

        /// <summary>
        /// 不可用余额(元)
        /// </summary>
        [XmlElement("format_not_available_amount_total")]
        public string FormatNotAvailableAmountTotal { get; set; }

        /// <summary>
        /// 现金(元)
        /// </summary>
        [XmlElement("format_principal_amount")]
        public string FormatPrincipalAmount { get; set; }

        /// <summary>
        /// 红包(元)
        /// </summary>
        [XmlElement("format_red_envelope_amount")]
        public string FormatRedEnvelopeAmount { get; set; }
    }
}
