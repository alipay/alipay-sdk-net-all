using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeyValueMap Data Structure.
    /// </summary>
    [Serializable]
    public class KeyValueMap : AopObject
    {
        /// <summary>
        /// key-value中的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// key-value中的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
