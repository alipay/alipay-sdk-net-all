using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasOrderQueryModel : AopObject
    {
        /// <summary>
        /// SaaS客户ID。传入时用于增强订单归属校验。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// SaaS交易订单号。与out_trade_no、trade_no至少传入一个；同时传入多个时必须指向同一笔交易。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。与order_no、trade_no至少传入一个；同时传入多个时必须指向同一笔交易。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询返回字段控制，使用JSON数组字符串格式。当前仅支持不传或传空数组。
        /// </summary>
        [XmlElement("query_options")]
        public string QueryOptions { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。与order_no、out_trade_no至少传入一个；同时传入多个时必须指向同一笔交易。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
