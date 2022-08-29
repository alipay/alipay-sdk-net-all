using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditagreementTransferModel : AopObject
    {
        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 用户的代扣协议号
        /// </summary>
        [XmlElement("deduct_agreement_no")]
        public string DeductAgreementNo { get; set; }

        /// <summary>
        /// 商户外部协议号，不同的支付宝用户需要传递不同的外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
