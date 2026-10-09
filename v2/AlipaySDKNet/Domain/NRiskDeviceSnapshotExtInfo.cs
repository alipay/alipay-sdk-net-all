using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NRiskDeviceSnapshotExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NRiskDeviceSnapshotExtInfo : AopObject
    {
        /// <summary>
        /// 设备关联的外部点位信息
        /// </summary>
        [XmlElement("bind_out_poi_id")]
        public string BindOutPoiId { get; set; }

        /// <summary>
        /// 设备关联的外部点位名称
        /// </summary>
        [XmlElement("bind_out_poi_name")]
        public string BindOutPoiName { get; set; }
    }
}
