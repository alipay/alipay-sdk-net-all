using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryTrack Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTrack : AopObject
    {
        /// <summary>
        /// 预计送达时间段
        /// </summary>
        [XmlElement("arrive_timeslot")]
        public HealthServiceTimeslot ArriveTimeslot { get; set; }

        /// <summary>
        /// 配送员纬度
        /// </summary>
        [XmlElement("courier_latitude")]
        public string CourierLatitude { get; set; }

        /// <summary>
        /// 配送员经度
        /// </summary>
        [XmlElement("courier_longitude")]
        public string CourierLongitude { get; set; }

        /// <summary>
        /// 配送员姓名
        /// </summary>
        [XmlElement("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 配送员电话
        /// </summary>
        [XmlElement("courier_phone")]
        public string CourierPhone { get; set; }

        /// <summary>
        /// 收货人纬度
        /// </summary>
        [XmlElement("receiver_latitude")]
        public string ReceiverLatitude { get; set; }

        /// <summary>
        /// 收货人经度
        /// </summary>
        [XmlElement("receiver_longitude")]
        public string ReceiverLongitude { get; set; }

        /// <summary>
        /// 剩余时间(分钟)
        /// </summary>
        [XmlElement("remaining_delivery_minutes")]
        public string RemainingDeliveryMinutes { get; set; }

        /// <summary>
        /// 剩余距离(km)
        /// </summary>
        [XmlElement("remaining_distance_km")]
        public string RemainingDistanceKm { get; set; }
    }
}
