using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleBankCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SettleBankCardInfo : AopObject
    {
        /// <summary>
        /// 银行支行名称
        /// </summary>
        [XmlElement("account_branch_name")]
        public string AccountBranchName { get; set; }

        /// <summary>
        /// 开户名称
        /// </summary>
        [XmlElement("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// 开户行所在市
        /// </summary>
        [XmlElement("account_inst_city")]
        public string AccountInstCity { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 开户行所在省
        /// </summary>
        [XmlElement("account_inst_province")]
        public string AccountInstProvince { get; set; }

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
        /// 01：对公，02：对私
        /// </summary>
        [XmlElement("usage_type")]
        public string UsageType { get; set; }
    }
}
