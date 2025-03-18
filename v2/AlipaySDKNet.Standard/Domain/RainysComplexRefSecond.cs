using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefSecond Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefSecond : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("schema_param_boolean")]
        [XmlArrayItem("boolean")]
        public List<bool> SchemaParamBoolean { get; set; }

        /// <summary>
        /// 数字类型
        /// </summary>
        [XmlElement("schema_param_num")]
        public long SchemaParamNum { get; set; }

        /// <summary>
        /// 字符串
        /// </summary>
        [XmlElement("schema_param_string")]
        public string SchemaParamString { get; set; }
    }
}
