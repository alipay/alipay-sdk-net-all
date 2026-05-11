using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDevicetagsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvDevicetagsSyncModel : AopObject
    {
        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备标签集合
        /// </summary>
        [XmlArray("device_label_infos")]
        [XmlArrayItem("device_label_info")]
        public List<DeviceLabelInfo> DeviceLabelInfos { get; set; }
    }
}
