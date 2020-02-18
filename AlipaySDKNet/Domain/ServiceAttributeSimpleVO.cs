using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceAttributeSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceAttributeSimpleVO : AopObject
    {
        /// <summary>
        /// 服务属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// abcd
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("string")]
        public List<string> Value { get; set; }
    }
}
