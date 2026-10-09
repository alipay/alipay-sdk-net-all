using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppDeliveryInfoSyncResponse.
    /// </summary>
    public class AlipayOpenAppDeliveryInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约信息ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
