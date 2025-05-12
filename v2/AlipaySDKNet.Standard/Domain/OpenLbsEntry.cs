using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenLbsEntry Data Structure.
    /// </summary>
    [Serializable]
    public class OpenLbsEntry : AopObject
    {
        /// <summary>
        /// 地理点位地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// lbs地理点位的纬度，<a href="https://lbs.amap.com/tools/picker">高德坐标拾取</a>
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// lbs地理点位的经度， <a href="https://lbs.amap.com/tools/picker">高德坐标拾取</a>
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 地理点位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 投放半径，千米（KM）
        /// </summary>
        [XmlElement("radius")]
        public string Radius { get; set; }
    }
}
