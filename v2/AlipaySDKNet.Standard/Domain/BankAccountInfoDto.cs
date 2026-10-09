using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankAccountInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class BankAccountInfoDto : AopObject
    {
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行支行名称
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 币种编码
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// ou编码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
