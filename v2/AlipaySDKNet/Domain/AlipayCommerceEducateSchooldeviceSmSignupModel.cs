using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchooldeviceSmSignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchooldeviceSmSignupModel : AopObject
    {
        /// <summary>
        /// 活动码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 经营内景照片
        /// </summary>
        [XmlArray("business_inner_image")]
        [XmlArrayItem("string")]
        public List<string> BusinessInnerImage { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [XmlArray("business_license_image")]
        [XmlArrayItem("string")]
        public List<string> BusinessLicenseImage { get; set; }

        /// <summary>
        /// 经营外景照片
        /// </summary>
        [XmlArray("business_outer_image")]
        [XmlArrayItem("string")]
        public List<string> BusinessOuterImage { get; set; }

        /// <summary>
        /// 合作协议扫描件
        /// </summary>
        [XmlArray("cooperation_agreement_image")]
        [XmlArrayItem("string")]
        public List<string> CooperationAgreementImage { get; set; }

        /// <summary>
        /// 法人证件照
        /// </summary>
        [XmlArray("legal_person_certification_image")]
        [XmlArrayItem("string")]
        public List<string> LegalPersonCertificationImage { get; set; }

        /// <summary>
        /// 间联商户ID
        /// </summary>
        [XmlElement("sm_id")]
        public string SmId { get; set; }
    }
}
