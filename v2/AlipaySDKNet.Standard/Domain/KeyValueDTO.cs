using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeyValueDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KeyValueDTO : AopObject
    {
        /// <summary>
        /// map中的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// map中的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
