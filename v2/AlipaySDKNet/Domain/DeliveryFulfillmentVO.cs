using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryFulfillmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryFulfillmentVO : AopObject
    {
        /// <summary>
        /// 发货频次
        /// </summary>
        [XmlElement("delivery_frequency")]
        public long DeliveryFrequency { get; set; }

        /// <summary>
        /// 总发货期数
        /// </summary>
        [XmlElement("total_delivery_times")]
        public long TotalDeliveryTimes { get; set; }

        /// <summary>
        /// 频次单位 WEEK：周
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
