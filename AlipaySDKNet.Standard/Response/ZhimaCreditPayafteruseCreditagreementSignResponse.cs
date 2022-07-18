using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementSignResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementSignResponse : AopResponse
    {
        /// <summary>
        /// 芝麻开通/授权协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
