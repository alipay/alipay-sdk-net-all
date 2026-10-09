using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceContent Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceContent : AopObject
    {
        /// <summary>
        /// 素材（节目）列表
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }
    }
}
