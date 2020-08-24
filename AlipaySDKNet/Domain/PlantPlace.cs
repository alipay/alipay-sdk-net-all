using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlantPlace Data Structure.
    /// </summary>
    [Serializable]
    public class PlantPlace : AopObject
    {
        /// <summary>
        /// 林区面积，单位：亩
        /// </summary>
        [XmlElement("acreage")]
        public string Acreage { get; set; }

        /// <summary>
        /// 树已经种下时所在的林区id
        /// </summary>
        [XmlElement("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 林区名称
        /// </summary>
        [XmlElement("forest_name")]
        public string ForestName { get; set; }

        /// <summary>
        /// 林区经纬度
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 公益机构名称
        /// </summary>
        [XmlElement("ngo_name")]
        public string NgoName { get; set; }

        /// <summary>
        /// 种植年份
        /// </summary>
        [XmlElement("plant_time")]
        public string PlantTime { get; set; }

        /// <summary>
        /// 种植所在区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 林区树木数量
        /// </summary>
        [XmlElement("tree_count")]
        public long TreeCount { get; set; }
    }
}
