using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerPaymentsCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerPaymentsCancelModel : AopObject
    {
        /// <summary>
        /// voyager授权返回的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付订单id
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付单请求号，非必填
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
