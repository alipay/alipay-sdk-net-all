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
        /// 芝麻开通/授权协议号，在用户开通芝麻先享服务后，由芝麻生成并返回给商户；只有当opertaion_type传入AGREEMENT_TRANSFER值是，该字段必传；其他场景不需要传入
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 用户的代扣协议号
        /// </summary>
        [XmlElement("deduct_agreement_no")]
        public string DeductAgreementNo { get; set; }

        /// <summary>
        /// 业务扩展参数，Json格式
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// AGREEMENT_TRANSFER代表是存量先享协议的主体切换功能；其他场景不需要传入；默认为空；
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 商户外部协议号，不同的支付宝用户需要传递不同的外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 商户签约的芝麻产品的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
