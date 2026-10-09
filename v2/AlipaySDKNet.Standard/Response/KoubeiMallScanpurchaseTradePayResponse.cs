using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTradePayResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTradePayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝收银单号
        /// </summary>
        [XmlElement("cashier_id")]
        public string CashierId { get; set; }

        /// <summary>
        /// 口碑商圈订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
