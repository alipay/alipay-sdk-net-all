using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterPayurlCreateResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterPayurlCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理状态
        /// </summary>
        [XmlElement("accept_result")]
        public string AcceptResult { get; set; }

        /// <summary>
        /// 收费账户的账户名
        /// </summary>
        [XmlElement("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 收费账户的账号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 收费账户对应的银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 标的编号
        /// </summary>
        [XmlElement("bid_no")]
        public string BidNo { get; set; }

        /// <summary>
        /// 收费金额
        /// </summary>
        [XmlElement("fee_amt")]
        public CreditPayMoneyVO FeeAmt { get; set; }

        /// <summary>
        /// 收费链接
        /// </summary>
        [XmlElement("fee_charge_url")]
        public string FeeChargeUrl { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
