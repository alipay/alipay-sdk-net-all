using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasOrderCloseResponse.
    /// </summary>
    public class AlipayTradeSaasOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 关闭时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// SaaS交易订单号。历史B2C交易不返回。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。历史B2C交易仅使用trade_no定位且无法恢复商户订单号时不返回。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。多渠道无法唯一表达时不返回。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 关闭后的交易状态，固定为TRADE_CLOSED。
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
