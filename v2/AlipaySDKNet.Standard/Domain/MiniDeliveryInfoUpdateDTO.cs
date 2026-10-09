using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniDeliveryInfoUpdateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniDeliveryInfoUpdateDTO : AopObject
    {
        /// <summary>
        /// 履约结束时间
        /// </summary>
        [XmlElement("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 履约开始时间
        /// </summary>
        [XmlElement("delivery_start_time")]
        public string DeliveryStartTime { get; set; }
    }
}
