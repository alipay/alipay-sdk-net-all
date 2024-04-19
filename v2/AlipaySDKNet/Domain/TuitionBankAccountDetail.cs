using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionBankAccountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionBankAccountDetail : AopObject
    {
        /// <summary>
        /// 银行收款账号
        /// </summary>
        [XmlElement("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 银行swiftCode/BIC
        /// </summary>
        [XmlElement("bank_bic")]
        public string BankBic { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行收款账户名
        /// </summary>
        [XmlElement("holder_account_name")]
        public TuitionUserName HolderAccountName { get; set; }

        /// <summary>
        /// 银行收款账户地址
        /// </summary>
        [XmlElement("holder_address")]
        public TuitionAddress HolderAddress { get; set; }

        /// <summary>
        /// 本地银行清算号
        /// </summary>
        [XmlElement("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
