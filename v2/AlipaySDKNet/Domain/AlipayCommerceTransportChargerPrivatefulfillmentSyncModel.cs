using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPrivatefulfillmentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPrivatefulfillmentSyncModel : AopObject
    {
        /// <summary>
        /// 履约信息
        /// </summary>
        [XmlElement("fulfillment")]
        public PrivateChargingOrder Fulfillment { get; set; }
    }
}
