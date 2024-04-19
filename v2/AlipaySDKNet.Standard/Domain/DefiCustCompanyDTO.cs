using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DefiCustCompanyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DefiCustCompanyDTO : AopObject
    {
        /// <summary>
        /// 企业证件号码
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业证件类型（2011-统一社会信用编码）
        /// </summary>
        [XmlElement("company_cert_type")]
        public string CompanyCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 法人证件类型（100-身份证，102-护照）
        /// </summary>
        [XmlElement("legal_person_cert_type")]
        public string LegalPersonCertType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }
    }
}
