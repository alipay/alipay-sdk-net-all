using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateQueryInfo : AopObject
    {
        /// <summary>
        /// 用户凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 三方码凭证券码。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("sku_info")]
        public CertificateSkuInfo SkuInfo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 开始生效时间
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
