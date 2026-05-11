using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcDeviceActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NfcDeviceActivityInfo : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("dvc_participate_info_list")]
        [XmlArrayItem("activity_participate_info")]
        public List<ActivityParticipateInfo> DvcParticipateInfoList { get; set; }
    }
}
