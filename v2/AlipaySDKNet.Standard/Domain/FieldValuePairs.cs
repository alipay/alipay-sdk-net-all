using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FieldValuePairs Data Structure.
    /// </summary>
    [Serializable]
    public class FieldValuePairs : AopObject
    {
        /// <summary>
        /// 特性key
        /// </summary>
        [XmlElement("field_key")]
        public string FieldKey { get; set; }

        /// <summary>
        /// enable有效/disable失效
        /// </summary>
        [XmlElement("field_status")]
        public string FieldStatus { get; set; }

        /// <summary>
        /// 特性标签值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
