using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundQueryResult : AopObject
    {
        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 转支付退款结果
        /// </summary>
        [XmlElement("transfer_refund_results")]
        public string TransferRefundResults { get; set; }
    }
}
