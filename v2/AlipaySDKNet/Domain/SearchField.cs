using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchField Data Structure.
    /// </summary>
    [Serializable]
    public class SearchField : AopObject
    {
        /// <summary>
        /// gmt_create
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// 操作符类型，取值见 enum（共18种）
        /// </summary>
        [XmlElement("field_operator_type")]
        public string FieldOperatorType { get; set; }

        /// <summary>
        /// 字段值（支持多种类型）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 字段变量名
        /// </summary>
        [XmlElement("variable_name")]
        public string VariableName { get; set; }
    }
}
