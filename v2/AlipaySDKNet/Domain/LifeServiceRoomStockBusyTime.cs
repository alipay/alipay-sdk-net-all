using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceRoomStockBusyTime Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceRoomStockBusyTime : AopObject
    {
        /// <summary>
        /// 无法预约的原因
        /// </summary>
        [XmlElement("busy_reason")]
        public string BusyReason { get; set; }

        /// <summary>
        /// 无法预约结束时间，要晚于busy_time_start
        /// </summary>
        [XmlElement("busy_time_end")]
        public string BusyTimeEnd { get; set; }

        /// <summary>
        /// 无法预约开始时间，HH:mm格式
        /// </summary>
        [XmlElement("busy_time_start")]
        public string BusyTimeStart { get; set; }
    }
}
