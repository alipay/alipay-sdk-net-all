using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceEcOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单同步成功后产生的支付宝订单号
        /// </summary>
        [XmlElement("order_sync_id")]
        public string OrderSyncId { get; set; }
    }
}
