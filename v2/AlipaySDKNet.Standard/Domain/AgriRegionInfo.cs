using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgriRegionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgriRegionInfo : AopObject
    {
        /// <summary>
        /// 坐标信息
        /// </summary>
        [XmlElement("geometry")]
        public string Geometry { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
