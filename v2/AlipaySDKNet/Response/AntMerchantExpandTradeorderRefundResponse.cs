using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderRefundResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderRefundResponse : AopResponse
    {
        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 退款金额；单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款单ID
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
