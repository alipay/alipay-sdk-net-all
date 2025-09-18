using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelUpdateExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LabelUpdateExtInfo : AopObject
    {
        /// <summary>
        /// 对齐JSON/Map结构，传入key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 对齐JSON/Map结构，传入value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
