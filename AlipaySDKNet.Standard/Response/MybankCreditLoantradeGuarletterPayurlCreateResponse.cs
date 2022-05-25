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
