using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPaymentMethodOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPaymentMethodOrder : AopObject
    {
        /// <summary>
        /// 银行账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行账户号码
        /// </summary>
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 账户类型, 接口仅做记录, 并不清楚上游的type枚举有哪些, 无法列举
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行地址
        /// </summary>
        [XmlElement("bank_address")]
        public string BankAddress { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行识别码
        /// </summary>
        [XmlElement("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// 分行代码
        /// </summary>
        [XmlElement("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// CNAPS code
        /// </summary>
        [XmlElement("cnaps_code")]
        public string CnapsCode { get; set; }

        /// <summary>
        /// 账号对应的币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 国际银行帐号
        /// </summary>
        [XmlElement("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("main_bank_bame")]
        public string MainBankBame { get; set; }

        /// <summary>
        /// 分行名称
        /// </summary>
        [XmlElement("sub_bank_name")]
        public string SubBankName { get; set; }

        /// <summary>
        /// 银行国际代码
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }
    }
}
