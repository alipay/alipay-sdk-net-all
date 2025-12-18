using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MeasureUnitInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MeasureUnitInfoVO : AopObject
    {
        /// <summary>
        /// 度量衡单位的模板id
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 度量衡单位列表
        /// </summary>
        [XmlArray("units")]
        [XmlArrayItem("measure_unit_v_o")]
        public List<MeasureUnitVO> Units { get; set; }
    }
}
