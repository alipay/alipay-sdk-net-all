using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreigtFlowAuthAccount Data Structure.
    /// </summary>
    [Serializable]
    public class FreigtFlowAuthAccount : AopObject
    {
        /// <summary>
        /// 授权方账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 网商账户：666/888的卡号.为授权方时必填
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 证件号+证件类型 -> CERT 证件号+证件类型+卡号 -> CERT_AND_CARD_NO
        /// </summary>
        [XmlElement("account_pattern")]
        public string AccountPattern { get; set; }

        /// <summary>
        /// 网商参与者：MYBANK ISV参与者：ISV 自然人: INDIVIDUAL 企业: CORPORATION
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 本期： ANT_MYBANK
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型 个人身份证: 100 企业统一信用编码: 2011
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }
    }
}
