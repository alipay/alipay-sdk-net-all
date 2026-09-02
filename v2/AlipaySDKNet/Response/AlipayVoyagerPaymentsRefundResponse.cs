using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerPaymentsRefundResponse.
    /// </summary>
    public class AlipayVoyagerPaymentsRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public MultiCurrencyMoneyDTO RefundAmount { get; set; }

        /// <summary>
        /// 退款订单号
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
