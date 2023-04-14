using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PersonInfo : AopObject
    {
        /// <summary>
        /// 身份证有效期开始日,格式（yyyy-MM-dd）
        /// </summary>
        [XmlElement("cert_effective_date")]
        public string CertEffectiveDate { get; set; }

        /// <summary>
        /// 身份证有效期到期日,格式（yyyy-MM-dd）,其中long 长期
        /// </summary>
        [XmlElement("cert_expiration_date")]
        public string CertExpirationDate { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，RESIDENT-居民身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
