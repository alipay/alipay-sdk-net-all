using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingUsercertificateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingUsercertificateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 证书MDM的证书编码
        /// </summary>
        [XmlElement("certificate_code")]
        public string CertificateCode { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 用户证书编码
        /// </summary>
        [XmlElement("user_certificate_code")]
        public string UserCertificateCode { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
