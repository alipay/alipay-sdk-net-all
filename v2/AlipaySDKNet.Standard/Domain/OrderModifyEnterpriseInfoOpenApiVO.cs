using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderModifyEnterpriseInfoOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderModifyEnterpriseInfoOpenApiVO : AopObject
    {
        /// <summary>
        /// 企业营业执照照片
        /// </summary>
        [XmlElement("enterprise_license_image_url")]
        public string EnterpriseLicenseImageUrl { get; set; }

        /// <summary>
        /// 公司的名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 法定代表人的身份证号码
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 法定代表人身份证照片
        /// </summary>
        [XmlElement("legal_person_emblem_cert_image_url")]
        public string LegalPersonEmblemCertImageUrl { get; set; }

        /// <summary>
        /// 法定代表人名称
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 公司的营业执照号码
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }
    }
}
