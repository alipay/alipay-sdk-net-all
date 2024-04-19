using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumeCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeCertificateInfo : AopObject
    {
        /// <summary>
        /// 证书等级
        /// </summary>
        [XmlElement("certificate_cert_level")]
        public string CertificateCertLevel { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 发证机构
        /// </summary>
        [XmlElement("certificate_send_card_address")]
        public string CertificateSendCardAddress { get; set; }

        /// <summary>
        /// UNPROMISED=未承诺 PROMISED=已承诺 VERFIED=已验真 UNVERIFIED=验证未通过
        /// </summary>
        [XmlElement("certificate_verify_status")]
        public string CertificateVerifyStatus { get; set; }

        /// <summary>
        /// VALID=有效 INVALID=失效 UNKNOWN=未知
        /// </summary>
        [XmlElement("in_validity_period")]
        public string InValidityPeriod { get; set; }
    }
}
