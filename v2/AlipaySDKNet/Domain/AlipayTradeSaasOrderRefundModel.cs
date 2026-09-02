using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasOrderRefundModel : AopObject
    {
        /// <summary>
        /// SaaS客户ID。传入时用于增强订单归属校验。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// SaaS交易订单号。与out_trade_no、trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户退款请求号。部分退款时必填，用于退款幂等；整单退款时可不传。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。与order_no、trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款返回字段控制，数组JSON字符串格式。当前支持refund_detail_item_list、gmt_refund_pay。
        /// </summary>
        [XmlElement("query_options")]
        public string QueryOptions { get; set; }

        /// <summary>
        /// 退款金额，单位为元，精确到小数点后2位。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因。
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。与order_no、out_trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
