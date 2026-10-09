using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDataRatingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDataRatingQueryModel : AopObject
    {
        /// <summary>
        /// 特定业务场景传输的扩展参数，以JSON形式传输
        /// </summary>
        [XmlElement("biz_ext_param")]
        public string BizExtParam { get; set; }

        /// <summary>
        /// 身份证上的姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业证件类型 工商注册号：NATIONAL_LEGAL 社会统一信用代码 : NATIONAL_LEGAL_MERGE
        /// </summary>
        [XmlElement("ep_cert_type")]
        public string EpCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，商户要保证其唯一性，可以传入流水号。建议：前面几位字符是商户自定义的简称，中间可以使用一段日期，结尾可以使用一个序列号。
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
