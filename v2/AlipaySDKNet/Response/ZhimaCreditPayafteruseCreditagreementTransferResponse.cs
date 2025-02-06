using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementTransferResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementTransferResponse : AopResponse
    {
        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 当operation_type==AGREEMENT_TRANSFER时，并且是迁移到小程序商家版时有值，其他情况下不返回
        /// </summary>
        [XmlElement("deduct_agreement_no")]
        public string DeductAgreementNo { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
