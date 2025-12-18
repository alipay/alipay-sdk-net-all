using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MeasureInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MeasureInfoVO : AopObject
    {
        /// <summary>
        /// 度量衡百分比单位信息，仅营养成分属性需要
        /// </summary>
        [XmlElement("percent_unit")]
        public MeasureUnitInfoVO PercentUnit { get; set; }

        /// <summary>
        /// 度量衡的模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 度量单位信息
        /// </summary>
        [XmlElement("unit_info")]
        public MeasureUnitInfoVO UnitInfo { get; set; }
    }
}
