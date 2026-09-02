using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// alipay.open.agent.delivery.submit返回的投放记录ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
