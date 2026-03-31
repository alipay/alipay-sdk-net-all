using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvDeviceBindModel : AopObject
    {
        /// <summary>
        /// 柜门类型
        /// </summary>
        [XmlElement("device_door_type")]
        public string DeviceDoorType { get; set; }

        /// <summary>
        /// IOT统一设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 0-否 1-是
        /// </summary>
        [XmlElement("dynamic_device")]
        public string DynamicDevice { get; set; }

        /// <summary>
        /// 设备所属商户pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户设备terminal id
        /// </summary>
        [XmlElement("isv_tid")]
        public string IsvTid { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }

        /// <summary>
        /// 设备注册类型
        /// </summary>
        [XmlElement("register_type")]
        public string RegisterType { get; set; }

        /// <summary>
        /// 0-否 1-是
        /// </summary>
        [XmlElement("weight_device")]
        public string WeightDevice { get; set; }
    }
}
