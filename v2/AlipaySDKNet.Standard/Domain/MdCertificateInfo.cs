using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MdCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MdCertificateInfo : AopObject
    {
        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号的具体值
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件的类型，如身份证、营业执照号等
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件正面图片地址
        /// </summary>
        [XmlElement("cert_url")]
        public string CertUrl { get; set; }

        /// <summary>
        /// 格式为 mmnn/yy/dd
        /// </summary>
        [XmlElement("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 格式为 mmnn/yy/dd
        /// </summary>
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }
    }
}
