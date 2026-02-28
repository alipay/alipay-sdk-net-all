using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BClassPaymentBankCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BClassPaymentBankCardInfo : AopObject
    {
        /// <summary>
        /// 开户支行
        /// </summary>
        [XmlElement("account_branch_name")]
        public string AccountBranchName { get; set; }

        /// <summary>
        /// 开户名
        /// </summary>
        [XmlElement("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// 开户行所在省市
        /// </summary>
        [XmlElement("account_inst_address")]
        public string AccountInstAddress { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("pbc_bank_code")]
        public string PbcBankCode { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("usage_type")]
        public string UsageType { get; set; }
    }
}
