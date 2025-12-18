using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MeasureUnitVO Data Structure.
    /// </summary>
    [Serializable]
    public class MeasureUnitVO : AopObject
    {
        /// <summary>
        /// 单位id，单位属性的属性值id
        /// </summary>
        [XmlElement("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 度量衡单位名称
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// 属性单位名称
        /// </summary>
        [XmlElement("unit_name_alias")]
        public string UnitNameAlias { get; set; }
    }
}
