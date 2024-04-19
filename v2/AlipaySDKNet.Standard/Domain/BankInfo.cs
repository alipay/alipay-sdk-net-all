using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankInfo : AopObject
    {
        /// <summary>
        /// 用户交易账号的发卡机构id
        /// </summary>
        [XmlElement("account_issue_entity_id")]
        public string AccountIssueEntityId { get; set; }

        /// <summary>
        /// 用户交易账号的发卡机构名称
        /// </summary>
        [XmlElement("account_issue_entity_name")]
        public string AccountIssueEntityName { get; set; }

        /// <summary>
        /// 用户在支付机构的开户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 用户在支付机构的账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 机构联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }
    }
}
