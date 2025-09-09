using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LegacyPreFilterValueDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LegacyPreFilterValueDetail : AopObject
    {
        /// <summary>
        /// 距离（仅地理坐标字段生效）
        /// </summary>
        [XmlElement("distance")]
        public LegacyPreFilterExtraValueDetail Distance { get; set; }

        /// <summary>
        /// 地理坐标（仅地理坐标字段生效）
        /// </summary>
        [XmlElement("geo_point")]
        public LegacyPreFilterExtraValueDetail GeoPoint { get; set; }

        /// <summary>
        /// 筛选值
        /// </summary>
        [XmlElement("value")]
        public LegacyPreFilterExtraValueDetail Value { get; set; }
    }
}
