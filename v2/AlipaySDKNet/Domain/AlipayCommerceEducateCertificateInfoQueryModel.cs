using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCertificateInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCertificateInfoQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展信息，json字符串格式
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
