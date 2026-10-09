using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchProductRegion Data Structure.
    /// </summary>
    [Serializable]
    public class SearchProductRegion : AopObject
    {
        /// <summary>
        /// 是否包含
        /// </summary>
        [XmlElement("is_excluded")]
        public string IsExcluded { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 半径
        /// </summary>
        [XmlElement("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [XmlElement("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// 区域类型（省、市、区县）
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
