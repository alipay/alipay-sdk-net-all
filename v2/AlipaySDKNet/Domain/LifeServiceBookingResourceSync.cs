using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceBookingResourceSync Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceBookingResourceSync : AopObject
    {
        /// <summary>
        /// 资源服务截止时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("booking_end_time")]
        public string BookingEndTime { get; set; }

        /// <summary>
        /// 资源服务开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("booking_start_time")]
        public string BookingStartTime { get; set; }

        /// <summary>
        /// 外部资源id
        /// </summary>
        [XmlElement("out_resource_id")]
        public string OutResourceId { get; set; }

        /// <summary>
        /// 预约资源id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源明细序号，从 1 开始；仅用于定位，创建后不允许修改或重排
        /// </summary>
        [XmlElement("resource_index")]
        public long ResourceIndex { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [XmlElement("resource_name")]
        public string ResourceName { get; set; }

        /// <summary>
        /// 预约资源类型；必须与存量明细类型一致，不允许通过本请求修改
        /// </summary>
        [XmlElement("resource_type")]
        public string ResourceType { get; set; }
    }
}
