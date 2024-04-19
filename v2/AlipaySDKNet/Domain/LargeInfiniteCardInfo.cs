using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LargeInfiniteCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LargeInfiniteCardInfo : AopObject
    {
        /// <summary>
        /// 账户余额,单位:元,精确到小数点后两位
        /// </summary>
        [XmlElement("account_balance")]
        public string AccountBalance { get; set; }

        /// <summary>
        /// 无限付产品转账的转入卡账户名称，支付宝分配。
        /// </summary>
        [XmlElement("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 无限付产品转账的转入卡账号，支付宝分配。
        /// </summary>
        [XmlElement("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行支行名称
        /// </summary>
        [XmlElement("bank_branch")]
        public string BankBranch { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行联行号
        /// </summary>
        [XmlElement("bank_branch_code")]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行开户地
        /// </summary>
        [XmlElement("open_place")]
        public string OpenPlace { get; set; }
    }
}
