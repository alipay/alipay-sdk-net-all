using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通/授权状态，VALID: 有效，INVALID: 无效
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 开通/授权时间，agreement_status为VALID时消费
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

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
