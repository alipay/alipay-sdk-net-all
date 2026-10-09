using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceBankAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceBankAccountInfo : AopObject
    {
        /// <summary>
        /// 银行账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行账户号码
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 开户银行地址
        /// </summary>
        [XmlElement("bank_address")]
        public string BankAddress { get; set; }

        /// <summary>
        /// 开户市
        /// </summary>
        [XmlElement("bank_city")]
        public string BankCity { get; set; }

        /// <summary>
        /// 开户银行编码
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 开户省
        /// </summary>
        [XmlElement("bank_province")]
        public string BankProvince { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("branch_id")]
        public string BranchId { get; set; }

        /// <summary>
        /// 开户支行
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// swift code
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }
    }
}
