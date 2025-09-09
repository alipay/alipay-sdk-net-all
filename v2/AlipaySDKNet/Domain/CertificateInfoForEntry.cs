using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateInfoForEntry Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateInfoForEntry : AopObject
    {
        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件图片类型
        /// </summary>
        [XmlElement("cert_pic_url_type")]
        public string CertPicUrlType { get; set; }

        /// <summary>
        /// 证件图片地址
        /// </summary>
        [XmlArray("cert_pic_urls")]
        [XmlArrayItem("string")]
        public List<string> CertPicUrls { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("reg_capital")]
        public string RegCapital { get; set; }
    }
}
