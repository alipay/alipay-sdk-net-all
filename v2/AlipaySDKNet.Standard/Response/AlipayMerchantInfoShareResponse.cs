using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantInfoShareResponse.
    /// </summary>
    public class AlipayMerchantInfoShareResponse : AopResponse
    {
        /// <summary>
        /// 证件地址-具体地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 证件地址-区
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 经营范围，partner_type非个人时存在
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 个人为个人证件号，单位为单位证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 企业主体证件类型，取值: BUSINESS_LICENSE: 营业执照 INST_RGST_CTF: 事业单位登记证书 COMM_RGST_CTF: 社会团体登记证书 NGO_CTF: 民办非企业单位证书 APRV_FILE: 党政机关批准设计文件 ORG_CERT: 全国组织机构代码证书
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件地址-市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 个人为个人证件有效期，单位为单位证件有效期。格式为yyyyMMdd或者"长期"
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 已认证 true，未认证 false
        /// </summary>
        [XmlElement("is_certified")]
        public bool IsCertified { get; set; }

        /// <summary>
        /// 个人无，单位为证件上登记的法定代表人/负责人姓名
        /// </summary>
        [XmlElement("legal_person_real_name")]
        public string LegalPersonRealName { get; set; }

        /// <summary>
        /// 个人为个人姓名，单位为单位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 个人 PRIVATE， 个体户 INDIVIDUAL_BUSINESS， 普通企业 ENTERPRISE， 党政机关 PARTY_AND_STATE_ORGAN， 事业单位 PUBLIC_INSTITUTION， 社会组织 SOCIAL_ORGANIZATION， 其他 OTHER
        /// </summary>
        [XmlElement("partner_type")]
        public string PartnerType { get; set; }

        /// <summary>
        /// 证件地址-省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
