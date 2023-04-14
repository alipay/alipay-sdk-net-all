using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StudentCertificate Data Structure.
    /// </summary>
    [Serializable]
    public class StudentCertificate : AopObject
    {
        /// <summary>
        /// 证书大分类
        /// </summary>
        [XmlElement("cert_category")]
        public string CertCategory { get; set; }

        /// <summary>
        /// 证书头编码
        /// </summary>
        [XmlElement("cert_code")]
        public string CertCode { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 外部证书编码
        /// </summary>
        [XmlElement("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证书描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 证书有效期开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 证书图片地址，oss永久地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 证书图片类型，pdf、png、jpg
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
