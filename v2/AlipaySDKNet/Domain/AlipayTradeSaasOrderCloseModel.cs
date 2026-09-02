using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasOrderCloseModel : AopObject
    {
        /// <summary>
        /// SaaS交易订单号。与out_trade_no、trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。与order_no、trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。与order_no、out_trade_no至少传入一个，多个字段同时传入时必须指向同一笔交易。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
