using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectCertificateInfo : AopObject
    {
        /// <summary>
        /// 证照图片（使用图片上传接口）
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 登记证书类型时必填，枚举：统一社会信用代码证书（UNIT_SOCIAL_CREDIT）、慈善组织公开募捐资格证书（CHARITY_ORG_SOLICIT），社会团体法人登记证书（SOCIAL_ORG_LEGAL），民办非企业单位登记证书（CIVIL_UN_ENT），基金会法人登记证书（FOUNDATION_LEGAL_PERSON），农民专业合作社法人营业执照（FARMERS_COOPERATE），宗教活动场所登记证（RELIGION_PLACES），其他证书/批文/证明（OTHER_REG_CERT）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证照生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 证照过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 证照法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 证照商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 证照注册地址
        /// </summary>
        [XmlElement("register_address")]
        public string RegisterAddress { get; set; }
    }
}
