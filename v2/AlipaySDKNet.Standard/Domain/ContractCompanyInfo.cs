using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractCompanyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractCompanyInfo : AopObject
    {
        /// <summary>
        /// 企业信用代码或者营业执照注册号
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业法人身份证号
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业法人名称
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 电子合同企业签署区配置，userType=COMPANY
        /// </summary>
        [XmlElement("sign_area")]
        public ContractSignArea SignArea { get; set; }
    }
}
