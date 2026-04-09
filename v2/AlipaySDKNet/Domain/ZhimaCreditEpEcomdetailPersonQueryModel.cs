using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEcomdetailPersonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEcomdetailPersonQueryModel : AopObject
    {
        /// <summary>
        /// 授权编号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 法人证件号
        /// </summary>
        [XmlElement("person_cert_no")]
        public string PersonCertNo { get; set; }

        /// <summary>
        /// 法人证件号md5值
        /// </summary>
        [XmlElement("person_cert_no_md_5")]
        public string PersonCertNoMd5 { get; set; }

        /// <summary>
        /// 法人证件号SHA256加密的密文
        /// </summary>
        [XmlElement("person_cert_no_sha_256")]
        public string PersonCertNoSha256 { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
