using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsCertificateInfo : AopObject
    {
        /// <summary>
        /// 证照图片
        /// </summary>
        [XmlElement("certificate_img")]
        public string CertificateImg { get; set; }

        /// <summary>
        /// 证照类型
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }
    }
}
