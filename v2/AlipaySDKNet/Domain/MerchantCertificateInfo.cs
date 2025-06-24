using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCertificateInfo : AopObject
    {
        /// <summary>
        /// 证件背面url，图片通过通过 ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("back_cert_url")]
        public string BackCertUrl { get; set; }

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
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件url，图片通过通过 ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("cert_url")]
        public string CertUrl { get; set; }

        /// <summary>
        /// 失效时间 日期格式 yyyy-mm-dd
        /// </summary>
        [XmlElement("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 生效时间 日期格式 yyyy-mm-dd
        /// </summary>
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }
    }
}
