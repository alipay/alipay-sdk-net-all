using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyAccountInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyAccountInfoModel : AopObject
    {
        /// <summary>
        /// 账户类型（alipay/bankcard）
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 账户类型是alipay时，取此字段。支付宝用户名（邮箱、手机号）
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 银行卡账户名
        /// </summary>
        [XmlElement("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 账户类型是bankcard时，取此字段。所属银行
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 收款银行卡号
        /// </summary>
        [XmlElement("bank_card_account")]
        public string BankCardAccount { get; set; }
    }
}
