using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QYBMapInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QYBMapInfo : AopObject
    {
        /// <summary>
        /// map里的key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// map类型的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
