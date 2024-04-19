using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyOrgIdentityQueryResponse.
    /// </summary>
    public class AlipayUserCertifyOrgIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业主体证件上记载的地址(详细地址)
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 企业主体证件上记载的经营范围
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 企业主体证件上的名称，也就是企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 企业主体证件的编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 企业主体证件类型，取值: BUSINESS_LICENSE: 营业执照 INST_RGST_CTF: 事业单位登记证书 COMM_RGST_CTF: 社会团体登记证书 NGO_CTF: 民办非企业单位证书 APRV_FILE: 党政机关批准设计文件 ORG_CERT: 全国组织机构代码证书
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业主体证件上记载的地址(市)
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 企业主体证件有效期，格式为yyyyMMdd或者"长期"
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 企业主体证件上记载的法定代表人/负责人姓名
        /// </summary>
        [XmlElement("legal_person_real_name")]
        public string LegalPersonRealName { get; set; }

        /// <summary>
        /// 企业主体证件上记载的地址(省份)
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
