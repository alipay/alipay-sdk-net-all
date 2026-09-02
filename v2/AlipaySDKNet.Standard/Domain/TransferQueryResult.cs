using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class TransferQueryResult : AopObject
    {
        /// <summary>
        /// 支付单支付宝交易号
        /// </summary>
        [XmlElement("pay_order_trade_no")]
        public string PayOrderTradeNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 转支付结果
        /// </summary>
        [XmlElement("transfer_pay_results")]
        public string TransferPayResults { get; set; }
    }
}
