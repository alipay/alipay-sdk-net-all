using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单回流事件ID
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
