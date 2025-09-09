using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectEventQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyRiskdetectEventQueryModel : AopObject
    {
        /// <summary>
        /// deviceId和outDeviceId至少传其一
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备时间查询结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 1. 消控室离岗识别: FMC_ABSENCE_DETECTION 2. 消控室睡岗识别: FMC_SLEEP_DETECTION 3. 消防通道占用识别: FIRE_LANE_OCCUPANCY_DETECTION
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// deviceId和outDeviceId至少传其一
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备时间查询开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
