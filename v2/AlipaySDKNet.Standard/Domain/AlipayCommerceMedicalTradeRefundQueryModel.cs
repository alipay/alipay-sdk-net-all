using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeRefundQueryModel : AopObject
    {
        /// <summary>
        /// 支付时传入的商户交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 同一笔交易多次请求撤销需保证唯一
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 逸康交易号和out_trade_no不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
