using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizOpenCertificateInfoForEntry Data Structure.
    /// </summary>
    [Serializable]
    public class BizOpenCertificateInfoForEntry : AopObject
    {
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
        [XmlElement("cert_pic_type")]
        public string CertPicType { get; set; }

        /// <summary>
        /// 证件图片,通过调用 ant.merchant.expand.indirect.image.upload(图片上传)接口返回的image_id作为参数
        /// </summary>
        [XmlArray("cert_pics")]
        [XmlArrayItem("string")]
        public List<string> CertPics { get; set; }

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
    }
}
