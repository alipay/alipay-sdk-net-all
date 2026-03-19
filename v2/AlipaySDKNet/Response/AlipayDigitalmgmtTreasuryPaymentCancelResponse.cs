using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtTreasuryPaymentCancelResponse.
    /// </summary>
    public class AlipayDigitalmgmtTreasuryPaymentCancelResponse : AopResponse
    {
        /// <summary>
        /// 付款撤销是否成功 true=成功 false=失败
        /// </summary>
        [XmlElement("payment_cancel_success")]
        public bool PaymentCancelSuccess { get; set; }
    }
}
