using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NRiskDeviceTagSnapshotExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NRiskDeviceTagSnapshotExtInfo : AopObject
    {
        /// <summary>
        /// 线圈关联的外部点位ID
        /// </summary>
        [XmlElement("bind_out_poi_id")]
        public string BindOutPoiId { get; set; }

        /// <summary>
        /// 线圈关联的外部点位名称
        /// </summary>
        [XmlElement("bind_poi_name")]
        public string BindPoiName { get; set; }
    }
}
