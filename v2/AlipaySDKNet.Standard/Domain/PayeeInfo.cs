using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayeeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayeeInfo : AopObject
    {
        /// <summary>
        /// 结算户名
        /// </summary>
        [XmlElement("payee_account_name")]
        public string PayeeAccountName { get; set; }

        /// <summary>
        /// 结算户号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 结算户所在银行联行号
        /// </summary>
        [XmlElement("payee_bank_code")]
        public string PayeeBankCode { get; set; }
    }
}
