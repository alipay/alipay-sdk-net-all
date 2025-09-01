using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingUsercertificateSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingUsercertificateSaveModel : AopObject
    {
        /// <summary>
        /// 证书MDM的证书ID
        /// </summary>
        [XmlElement("certificate_code")]
        public string CertificateCode { get; set; }

        /// <summary>
        /// 证书MDM的证书名称
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("certification_time")]
        public string CertificationTime { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 评价机构
        /// </summary>
        [XmlElement("rating_org")]
        public string RatingOrg { get; set; }

        /// <summary>
        /// 用户证书编码
        /// </summary>
        [XmlElement("user_certificate_code")]
        public string UserCertificateCode { get; set; }

        /// <summary>
        /// 用户证书级别
        /// </summary>
        [XmlElement("user_certificate_level")]
        public string UserCertificateLevel { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
