using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicExtInfo : AopObject
    {
        /// <summary>
        /// key的值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
