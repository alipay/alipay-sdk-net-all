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
        /// 扩展参数
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 当产品是芝麻守约时必填，需传入CREDIT_AGREEMENT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 芝麻信用服务id，上线前提前分配给商户
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
