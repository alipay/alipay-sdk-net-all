using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerPaymentsRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerPaymentsRefundQueryModel : AopObject
    {
        /// <summary>
        /// open_i
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 退款订单id
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款请求id
        /// </summary>
        [XmlElement("refund_request_id")]
        public string RefundRequestId { get; set; }

        /// <summary>
        /// userId，用户userId，用于接受openId转换
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
