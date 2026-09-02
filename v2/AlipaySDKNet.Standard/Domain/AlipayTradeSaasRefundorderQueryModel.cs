using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasRefundorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasRefundorderQueryModel : AopObject
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
        /// 商户退款请求号。传入时查询对应退款，不传时查询整单退款记录。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。与order_no、trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款查询返回字段控制，数组JSON字符串格式。当前支持refund_detail_item_list、gmt_refund_pay。
        /// </summary>
        [XmlElement("query_options")]
        public string QueryOptions { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。与order_no、out_trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
