using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyDeviceSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyDeviceSaveModel : AopObject
    {
        /// <summary>
        /// 用于外部服务商通过Api接口管理设备信息
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 新增时该值不填写
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("enable_status")]
        public string EnableStatus { get; set; }

        /// <summary>
        /// 开门配置
        /// </summary>
        [XmlElement("entrance_open_config")]
        public string EntranceOpenConfig { get; set; }

        /// <summary>
        /// 开门调用类型
        /// </summary>
        [XmlElement("entrance_open_type")]
        public string EntranceOpenType { get; set; }

        /// <summary>
        /// 新增时该必须填写。 更新时deviceId及outDeviceId二选一，同时填写时以deviceId为准。
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }

        /// <summary>
        /// 是否支持远程开门
        /// </summary>
        [XmlElement("support_open")]
        public bool SupportOpen { get; set; }
    }
}
