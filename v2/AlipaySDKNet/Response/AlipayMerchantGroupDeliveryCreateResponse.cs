using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryCreateResponse.
    /// </summary>
    public class AlipayMerchantGroupDeliveryCreateResponse : AopResponse
    {
        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
