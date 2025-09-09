using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrustAccountInfo : AopObject
    {
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("bank_branch_code")]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// 开户支行
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 是否个人个人账号，不填默认对公账号
        /// </summary>
        [XmlElement("personal_acc")]
        public bool PersonalAcc { get; set; }
    }
}
