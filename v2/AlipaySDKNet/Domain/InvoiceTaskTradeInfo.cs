using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTaskTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTaskTradeInfo : AopObject
    {
        /// <summary>
        /// 应回票金额，以元为单位
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 交易金额，以元为单位
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易类型 支付：PAYMENT 退款：REFUND
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
