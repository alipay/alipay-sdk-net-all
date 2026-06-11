using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTailpaymentCreateResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTailpaymentCreateResponse : AopResponse
    {
        /// <summary>
        /// 尾款id
        /// </summary>
        [XmlElement("tail_payment_id")]
        public string TailPaymentId { get; set; }

        /// <summary>
        /// 尾款支付链接
        /// </summary>
        [XmlElement("tail_payment_order_pay_url")]
        public string TailPaymentOrderPayUrl { get; set; }
    }
}
