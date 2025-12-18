using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyDeviceEventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyDeviceEventSyncModel : AopObject
    {
        /// <summary>
        /// 设备SN，唯一标识触发事件的门禁设备。
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 门禁事件发生的时间。若不传该值，默认取当前时间。
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 门禁设备产生的事件，如开门事件。
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 开门人手机的一个定位纬度，传递精度必须保留到小数点后6位。
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 定位时间
        /// </summary>
        [XmlElement("location_time")]
        public string LocationTime { get; set; }

        /// <summary>
        /// 开门人手机的一个定位经度，传递精度必须保留到小数点后6位。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝uid，代表通过门禁的人。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid，代表通过门禁的人。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
