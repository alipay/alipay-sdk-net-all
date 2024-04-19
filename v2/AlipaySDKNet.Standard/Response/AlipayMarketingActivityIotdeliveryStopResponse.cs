using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryStopResponse.
    /// </summary>
    public class AlipayMarketingActivityIotdeliveryStopResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
