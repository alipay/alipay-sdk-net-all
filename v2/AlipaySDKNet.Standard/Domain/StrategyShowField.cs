using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StrategyShowField Data Structure.
    /// </summary>
    [Serializable]
    public class StrategyShowField : AopObject
    {
        /// <summary>
        /// 组件名称
        /// </summary>
        [XmlElement("component_name")]
        public string ComponentName { get; set; }

        /// <summary>
        /// 字段编码
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }
    }
}
