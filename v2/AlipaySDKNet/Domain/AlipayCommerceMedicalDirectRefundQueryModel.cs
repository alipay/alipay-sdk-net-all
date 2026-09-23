using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDirectRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDirectRefundQueryModel : AopObject
    {
        /// <summary>
        /// 外部交易号，该字段与逸康交易号不能都为空
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款请求流水号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 创建交易单时返回的逸康交易单号，该字段与外部交易号不能都为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
