using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Kv Data Structure.
    /// </summary>
    [Serializable]
    public class Kv : AopObject
    {
        /// <summary>
        /// 参数key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
