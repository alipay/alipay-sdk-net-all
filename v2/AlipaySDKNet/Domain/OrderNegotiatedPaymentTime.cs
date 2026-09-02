using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderNegotiatedPaymentTime Data Structure.
    /// </summary>
    [Serializable]
    public class OrderNegotiatedPaymentTime : AopObject
    {
        /// <summary>
        /// 租期。标识第几期，起始值为1，需保证编号递增
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 协商支付时间，表示商家与用户协议一致的支付时间
        /// </summary>
        [XmlElement("negotiated_payment_time")]
        public string NegotiatedPaymentTime { get; set; }
    }
}
