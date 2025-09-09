using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReferenceBankAccount Data Structure.
    /// </summary>
    [Serializable]
    public class ReferenceBankAccount : AopObject
    {
        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [XmlElement("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }
    }
}
