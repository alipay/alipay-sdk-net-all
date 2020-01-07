using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppFlowStatusQueryResponse.
    /// </summary>
    public class AlipayEbppFlowStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [XmlElement("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 订单状态  S:成功  F:失败  P:处理中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 外表订单号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
