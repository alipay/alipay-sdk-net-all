using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingShowwindowContentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingShowwindowContentSyncModel : AopObject
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [XmlArray("device_info_list")]
        [XmlArrayItem("iot_device_info")]
        public List<IotDeviceInfo> DeviceInfoList { get; set; }

        /// <summary>
        /// 节目更新事件类型标记
        /// </summary>
        [XmlElement("event_tag")]
        public string EventTag { get; set; }

        /// <summary>
        /// 接口请求源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
