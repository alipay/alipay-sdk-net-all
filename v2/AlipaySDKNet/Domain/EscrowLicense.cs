using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EscrowLicense Data Structure.
    /// </summary>
    [Serializable]
    public class EscrowLicense : AopObject
    {
        /// <summary>
        /// 证件有效期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("cert_expired_date")]
        public string CertExpiredDate { get; set; }

        /// <summary>
        /// 认证手机号
        /// </summary>
        [XmlElement("cert_mobile")]
        public string CertMobile { get; set; }

        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 个人传递身份证号，企业传递营业执照
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证: IDENTITY_CARD 营业执照: BUSINESS_LICENSE
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 法人证件过期日期（企业必填）
        /// </summary>
        [XmlElement("legal_person_cert_expired_date")]
        public string LegalPersonCertExpiredDate { get; set; }

        /// <summary>
        /// 法人证件号码（企业必填）
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 身份证: IDENTITY_CARD
        /// </summary>
        [XmlElement("legal_person_cert_type")]
        public string LegalPersonCertType { get; set; }

        /// <summary>
        /// 法人手机号码（企业必填）
        /// </summary>
        [XmlElement("legal_person_mobile")]
        public string LegalPersonMobile { get; set; }

        /// <summary>
        /// 法人真实姓名
        /// </summary>
        [XmlElement("legal_person_real_name")]
        public string LegalPersonRealName { get; set; }

        /// <summary>
        /// 详细地址信息，企业填营业执照地址，个人填身份证地址
        /// </summary>
        [XmlElement("license_address")]
        public string LicenseAddress { get; set; }

        /// <summary>
        /// 支付宝账户真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }
    }
}
