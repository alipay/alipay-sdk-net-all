using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceCustomerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceCustomerCreateModel : AopObject
    {
        /// <summary>
        /// 企业联系邮箱号
        /// </summary>
        [XmlElement("company_email")]
        public string CompanyEmail { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业法人证件号码
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业法人证件类型，100：居民身份证
        /// </summary>
        [XmlElement("legal_person_cert_type")]
        public string LegalPersonCertType { get; set; }

        /// <summary>
        /// 企业法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 企业法人手机号
        /// </summary>
        [XmlElement("legal_person_phone_num")]
        public string LegalPersonPhoneNum { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 企业角色，核心企业和供应商，CORE_BUSINESS和SUPPLIER
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 操作员证件号码
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 证件类型，100：居民身份证
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [XmlElement("user_person_name")]
        public string UserPersonName { get; set; }

        /// <summary>
        /// 操作员手机号
        /// </summary>
        [XmlElement("user_phone_num")]
        public string UserPhoneNum { get; set; }
    }
}
