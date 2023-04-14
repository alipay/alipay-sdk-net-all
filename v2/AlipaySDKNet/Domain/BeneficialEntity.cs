using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BeneficialEntity Data Structure.
    /// </summary>
    [Serializable]
    public class BeneficialEntity : AopObject
    {
        /// <summary>
        /// 证件有效期开始日,格式（yyyy-MM-dd）
        /// </summary>
        [XmlElement("cert_effective_date")]
        public string CertEffectiveDate { get; set; }

        /// <summary>
        /// 证件有效期到期日,格式（yyyy-MM-dd）,其中long 长期
        /// </summary>
        [XmlElement("cert_expiration_date")]
        public string CertExpirationDate { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，RESIDENT-居民身份证，NATIONAL_LEGAL-全国法人营业执照，NATIONAL_LEGAL_MERGE-全国法人营业执照-多证合一
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
