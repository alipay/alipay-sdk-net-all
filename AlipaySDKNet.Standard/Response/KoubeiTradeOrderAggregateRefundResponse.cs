using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeOrderAggregateRefundResponse.
    /// </summary>
    public class KoubeiTradeOrderAggregateRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("gmt_refund_time")]
        public string GmtRefundTime { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// PROCESSING - 退款处理中 FAILED - 退款失败
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部订单号； 同一商户下必须唯一，用来控制幂等
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部退款单号 ； 同一商户下必须唯一，用来控制幂等
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [XmlElement("refund_buyer_amount")]
        public string RefundBuyerAmount { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [XmlElement("refund_discount_amount")]
        public string RefundDiscountAmount { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("refund_mdiscount_amount")]
        public string RefundMdiscountAmount { get; set; }

        /// <summary>
        /// 口碑退款单ID
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 实际退款金额
        /// </summary>
        [XmlElement("refund_real_amount")]
        public string RefundRealAmount { get; set; }

        /// <summary>
        /// 支付宝/微信交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
