using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EscrowSettleCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EscrowSettleCardInfo : AopObject
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户支行省市
        /// </summary>
        [XmlElement("branch_address")]
        public string BranchAddress { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型，01 对公，02 对私
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("pbc_bank_code")]
        public string PbcBankCode { get; set; }
    }
}
