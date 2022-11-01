using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HeatMapData Data Structure.
    /// </summary>
    [Serializable]
    public class HeatMapData : AopObject
    {
        /// <summary>
        /// 城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 热力图所在时间片结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 热力图栅栏列表
        /// </summary>
        [XmlArray("fences")]
        [XmlArrayItem("fence")]
        public List<Fence> Fences { get; set; }

        /// <summary>
        /// 热力图所在时间片开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
