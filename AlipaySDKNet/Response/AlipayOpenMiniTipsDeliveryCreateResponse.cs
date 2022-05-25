using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTipsDeliveryCreateResponse.
    /// </summary>
    public class AlipayOpenMiniTipsDeliveryCreateResponse : AopResponse
    {
        /// <summary>
        /// 收藏引导活动ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
