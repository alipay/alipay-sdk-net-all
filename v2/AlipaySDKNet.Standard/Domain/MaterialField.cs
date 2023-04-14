using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaterialField Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialField : AopObject
    {
        /// <summary>
        /// 素材字段名称，来源于素材规范定义的字段名称。注意一次素材提报中字段名称不能重复。
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 素材字段值，素材字段提报的实际值，支持多值，具体的要求请查看素材规范或对应的产品文档。
        /// </summary>
        [XmlArray("field_value")]
        [XmlArrayItem("string")]
        public List<string> FieldValue { get; set; }
    }
}
