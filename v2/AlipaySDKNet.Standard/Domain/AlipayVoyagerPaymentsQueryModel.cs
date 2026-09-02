using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerPaymentsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerPaymentsQueryModel : AopObject
    {
        /// <summary>
        /// 用户授权Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付单ID，由Antom分配（与payment_request_id二选一必填）
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付请求ID，由商户分配（与pay_order_id二选一必填）
        /// </summary>
        [XmlElement("payment_request_id")]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
