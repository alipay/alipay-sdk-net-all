using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeviceBindBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeviceBindBaseInfo : AopObject
    {
        /// <summary>
        /// [{"name":"未绑定","value":"UN_BIND"},{"name":"已绑定","value":"BIND"}]
        /// </summary>
        [XmlElement("device_bind_status")]
        public string DeviceBindStatus { get; set; }

        /// <summary>
        /// 1. 直连绑定必传： RECORDS_TYPE_PID(直连 PID)、 RECORDS_TYPE_SHOPID(shopid);  2. 间连绑定必传： RECORDS_TYPE_SMID（二级商家 ID）
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_info")]
        public List<DeviceRecordInfo> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商家在服务商系统内身份资料
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtAttribute ExtParams { get; set; }
    }
}
