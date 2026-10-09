using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
