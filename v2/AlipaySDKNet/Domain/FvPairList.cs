using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FvPairList Data Structure.
    /// </summary>
    [Serializable]
    public class FvPairList : AopObject
    {
        /// <summary>
        /// 具体的字段代号
        /// </summary>
        [XmlElement("field_code")]
        public string FieldCode { get; set; }

        /// <summary>
        /// 具体的字段值
        /// </summary>
        [XmlElement("field_value")]
        public string FieldValue { get; set; }
    }
}
