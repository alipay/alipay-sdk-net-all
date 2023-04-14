using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityIotdeliveryCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
