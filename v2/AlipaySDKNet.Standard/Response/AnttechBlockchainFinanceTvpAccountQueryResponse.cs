using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 关联支付宝账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 子账号余额，单位元
        /// </summary>
        [XmlElement("balance_amount")]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// 关联银行账号信息
        /// </summary>
        [XmlElement("reference_bank_account")]
        public ReferenceBankAccount ReferenceBankAccount { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
