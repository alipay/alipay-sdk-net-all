using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTailpaymentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTailpaymentCancelModel : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 尾款id
        /// </summary>
        [XmlElement("tail_payment_id")]
        public string TailPaymentId { get; set; }
    }
}
