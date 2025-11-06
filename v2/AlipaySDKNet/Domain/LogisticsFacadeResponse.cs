using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsFacadeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsFacadeResponse : AopObject
    {
        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
