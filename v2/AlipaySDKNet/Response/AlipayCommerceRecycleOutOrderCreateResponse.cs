using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOutOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceRecycleOutOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
