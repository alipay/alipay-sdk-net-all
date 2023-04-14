using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderSettleQueryModel : AopObject
    {
        /// <summary>
        /// 外部请求号，需要和支付宝交易号一起传入
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝分账请求单号，传入该字段，无需再传外部请求号和支付宝交易号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }

        /// <summary>
        /// 支付宝交易号，传入该字段，需要和外部请求号一起传入
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
