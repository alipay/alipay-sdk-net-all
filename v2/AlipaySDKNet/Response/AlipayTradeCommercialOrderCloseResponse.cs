using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCommercialOrderCloseResponse.
    /// </summary>
    public class AlipayTradeCommercialOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 订单关闭时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 本次关闭的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
