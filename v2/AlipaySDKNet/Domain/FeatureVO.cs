using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeatureVO Data Structure.
    /// </summary>
    [Serializable]
    public class FeatureVO : AopObject
    {
        /// <summary>
        /// 是否支持拥挤度。枚举：Y=支持，N=不支持。
        /// </summary>
        [XmlElement("congestion_rate")]
        public string CongestionRate { get; set; }

        /// <summary>
        /// 是否支持实时时刻。枚举：Y=支持，N=不支持。N 时实时接口该城市可能无数据。
        /// </summary>
        [XmlElement("real_time")]
        public string RealTime { get; set; }

        /// <summary>
        /// 是否支持首末班车。枚举：Y=支持，N=不支持。
        /// </summary>
        [XmlElement("start_end")]
        public string StartEnd { get; set; }
    }
}
