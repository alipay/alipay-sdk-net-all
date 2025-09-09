using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotCareWorkOrder Data Structure.
    /// </summary>
    [Serializable]
    public class IotCareWorkOrder : AopObject
    {
        /// <summary>
        /// 用于标识是何种系列的设备
        /// </summary>
        [XmlElement("device_category_name")]
        public string DeviceCategoryName { get; set; }

        /// <summary>
        /// 新机sn
        /// </summary>
        [XmlElement("new_device_sn")]
        public string NewDeviceSn { get; set; }

        /// <summary>
        /// 工单提报设备SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 工单创建时间
        /// </summary>
        [XmlElement("worker_order_create_time")]
        public string WorkerOrderCreateTime { get; set; }

        /// <summary>
        /// 工单完结时间
        /// </summary>
        [XmlElement("worker_order_end_time")]
        public string WorkerOrderEndTime { get; set; }

        /// <summary>
        /// 维保工单号
        /// </summary>
        [XmlElement("worker_order_id")]
        public string WorkerOrderId { get; set; }
    }
}
