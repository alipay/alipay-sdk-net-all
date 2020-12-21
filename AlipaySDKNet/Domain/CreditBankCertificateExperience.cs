using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditBankCertificateExperience Data Structure.
    /// </summary>
    [Serializable]
    public class CreditBankCertificateExperience : AopObject
    {
        /// <summary>
        /// 获得证书id
        /// </summary>
        [XmlElement("cert_exp_outer_id")]
        public string CertExpOuterId { get; set; }

        /// <summary>
        /// 证书等级
        /// </summary>
        [XmlElement("certificate_level")]
        public string CertificateLevel { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [XmlElement("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
