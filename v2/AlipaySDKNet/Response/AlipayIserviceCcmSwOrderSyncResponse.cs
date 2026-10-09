using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwOrderSyncResponse.
    /// </summary>
    public class AlipayIserviceCcmSwOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
