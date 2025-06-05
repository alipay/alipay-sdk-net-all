using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Location Data Structure.
    /// </summary>
    [Serializable]
    public class Location : AopObject
    {
        /// <summary>
        /// 朝向角度
        /// </summary>
        [XmlElement("angle")]
        public string Angle { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 位置扩展信息列表
        /// </summary>
        [XmlArray("location_ext_infos")]
        [XmlArrayItem("transport_ext_info")]
        public List<TransportExtInfo> LocationExtInfos { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("tips")]
        public TipInfo Tips { get; set; }
    }
}
