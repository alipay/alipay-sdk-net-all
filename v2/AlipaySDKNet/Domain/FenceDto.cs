using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FenceDto Data Structure.
    /// </summary>
    [Serializable]
    public class FenceDto : AopObject
    {
        /// <summary>
        /// 围栏坐标点列表
        /// </summary>
        [XmlArray("coordinates")]
        [XmlArrayItem("gps_info")]
        public List<GpsInfo> Coordinates { get; set; }

        /// <summary>
        /// 围栏属性
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }
    }
}
