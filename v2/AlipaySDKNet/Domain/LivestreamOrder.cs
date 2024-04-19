using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LivestreamOrder Data Structure.
    /// </summary>
    [Serializable]
    public class LivestreamOrder : AopObject
    {
        /// <summary>
        /// 订单实付额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 淘宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单付款时间
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        [XmlElement("receipt_confirm_time")]
        public string ReceiptConfirmTime { get; set; }

        /// <summary>
        /// 主播id
        /// </summary>
        [XmlElement("streamer_id")]
        public string StreamerId { get; set; }
    }
}
