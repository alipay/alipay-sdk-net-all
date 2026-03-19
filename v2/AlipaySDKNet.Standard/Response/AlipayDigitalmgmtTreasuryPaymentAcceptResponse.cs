using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtTreasuryPaymentAcceptResponse.
    /// </summary>
    public class AlipayDigitalmgmtTreasuryPaymentAcceptResponse : AopResponse
    {
        /// <summary>
        /// 受理单ID
        /// </summary>
        [XmlElement("payment_accept_id")]
        public string PaymentAcceptId { get; set; }

        /// <summary>
        /// 付款受理是否成功，true-成功 false-失败
        /// </summary>
        [XmlElement("payment_accept_success")]
        public bool PaymentAcceptSuccess { get; set; }
    }
}
