using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeRecommendDetectModel : AopObject
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 订单中心ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
