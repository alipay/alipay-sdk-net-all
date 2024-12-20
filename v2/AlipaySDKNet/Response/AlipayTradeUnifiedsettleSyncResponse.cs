using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeUnifiedsettleSyncResponse.
    /// </summary>
    public class AlipayTradeUnifiedsettleSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单同步受理单号
        /// </summary>
        [XmlElement("order_sync_id")]
        public string OrderSyncId { get; set; }
    }
}
