using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Certificate Data Structure.
    /// </summary>
    [Serializable]
    public class Certificate : AopObject
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
    }
}
