using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderCertificateInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderCertificateInfoVO : AopObject
    {
        /// <summary>
        /// 本地商品对应的凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 本地生活商品凭证生效日期
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 本地生活商品凭证失效日期
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 本地生活商品凭证核销时间
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }
    }
}
