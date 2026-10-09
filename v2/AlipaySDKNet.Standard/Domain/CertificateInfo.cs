using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateInfo : AopObject
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 身份证md5加密后字符串
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }
    }
}
