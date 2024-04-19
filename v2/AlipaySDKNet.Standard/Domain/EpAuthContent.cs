using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAuthContent Data Structure.
    /// </summary>
    [Serializable]
    public class EpAuthContent : AopObject
    {
        /// <summary>
        /// 企业信用等级
        /// </summary>
        [XmlElement("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 企业授权单号
        /// </summary>
        [XmlElement("ep_auth_no")]
        public string EpAuthNo { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 证件号码，仅支持身份证号
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }
    }
}
