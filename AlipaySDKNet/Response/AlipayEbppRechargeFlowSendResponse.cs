using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeFlowSendResponse.
    /// </summary>
    public class AlipayEbppRechargeFlowSendResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部交易号
        /// </summary>
        [XmlElement("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// P:已接受，处理中  F:兑换上送失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 外部交易id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
