using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParamEntry Data Structure.
    /// </summary>
    [Serializable]
    public class ParamEntry : AopObject
    {
        /// <summary>
        /// key值，主要包含一些人群相关的字段，如人群id，人群行为
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// value值，key值对应的字段的具体值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
