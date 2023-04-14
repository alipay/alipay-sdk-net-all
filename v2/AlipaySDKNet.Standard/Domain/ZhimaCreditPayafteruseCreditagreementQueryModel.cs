using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditagreementQueryModel : AopObject
    {
        /// <summary>
        /// 芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。
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
