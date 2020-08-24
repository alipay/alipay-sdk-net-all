using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionCertificate Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionCertificate : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证件生效时间
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 证件有效截止时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        [XmlElement("holder_name")]
        public TuitionUserName HolderName { get; set; }
    }
}
