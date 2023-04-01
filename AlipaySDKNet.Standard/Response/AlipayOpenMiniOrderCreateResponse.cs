using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderCreateResponse.
    /// </summary>
    public class AlipayOpenMiniOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }
    }
}
