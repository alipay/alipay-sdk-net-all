using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SuccessDeliveryConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SuccessDeliveryConfig : AopObject
    {
        /// <summary>
        /// 投放配置。
        /// </summary>
        [XmlElement("delivery_config")]
        public DeliveryConfig DeliveryConfig { get; set; }
    }
}
