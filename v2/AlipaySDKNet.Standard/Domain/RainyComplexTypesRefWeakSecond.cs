using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesRefWeakSecond Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesRefWeakSecond : AopObject
    {
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
