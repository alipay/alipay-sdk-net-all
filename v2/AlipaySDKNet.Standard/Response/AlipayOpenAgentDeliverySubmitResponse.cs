using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentDeliverySubmitResponse.
    /// </summary>
    public class AlipayOpenAgentDeliverySubmitResponse : AopResponse
    {
        /// <summary>
        /// 投放记录唯一标识,用于查询该次投放状态
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
