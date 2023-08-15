using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficRule Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficRule : AopObject
    {
        /// <summary>
        /// 流量占比
        /// </summary>
        [XmlElement("traffic_ratio")]
        public string TrafficRatio { get; set; }

        /// <summary>
        /// 云函数版本名称
        /// </summary>
        [XmlElement("version_name")]
        public string VersionName { get; set; }
    }
}
