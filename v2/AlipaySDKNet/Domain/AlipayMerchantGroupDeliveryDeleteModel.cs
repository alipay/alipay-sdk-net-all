using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupDeliveryDeleteModel : AopObject
    {
        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
