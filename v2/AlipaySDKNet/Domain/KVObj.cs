using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KVObj Data Structure.
    /// </summary>
    [Serializable]
    public class KVObj : AopObject
    {
        /// <summary>
        /// KV模型的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// KV模型的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
