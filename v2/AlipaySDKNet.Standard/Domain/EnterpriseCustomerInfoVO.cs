using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseCustomerInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseCustomerInfoVO : AopObject
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 企业地址（开票用）
        /// </summary>
        [XmlElement("enterprise_addr")]
        public string EnterpriseAddr { get; set; }

        /// <summary>
        /// 企业银行卡卡名
        /// </summary>
        [XmlElement("enterprise_bank_card_name")]
        public string EnterpriseBankCardName { get; set; }

        /// <summary>
        /// 开户行名称（开票用）
        /// </summary>
        [XmlElement("enterprise_bank_name")]
        public string EnterpriseBankName { get; set; }

        /// <summary>
        /// 银行企业账号（开票用）
        /// </summary>
        [XmlElement("enterprise_bank_no")]
        public string EnterpriseBankNo { get; set; }

        /// <summary>
        /// 企业电话号码
        /// </summary>
        [XmlElement("enterprise_phone")]
        public string EnterprisePhone { get; set; }

        /// <summary>
        /// 法人证件号码（身份证）
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人手机号
        /// </summary>
        [XmlElement("legal_mobile_phone")]
        public string LegalMobilePhone { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("unified_social_cert_code")]
        public string UnifiedSocialCertCode { get; set; }
    }
}
