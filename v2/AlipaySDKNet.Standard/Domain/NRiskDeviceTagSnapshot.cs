using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NRiskDeviceTagSnapshot Data Structure.
    /// </summary>
    [Serializable]
    public class NRiskDeviceTagSnapshot : AopObject
    {
        /// <summary>
        /// 描叙N线圈类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// N线圈数据的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public NRiskDeviceTagSnapshotExtInfo ExtInfo { get; set; }

        /// <summary>
        /// N线圈的唯一标识
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
