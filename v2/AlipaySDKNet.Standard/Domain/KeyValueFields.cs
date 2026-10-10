using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeyValueFields Data Structure.
    /// </summary>
    [Serializable]
    public class KeyValueFields : AopObject
    {
        /// <summary>
        /// 字段编码
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
