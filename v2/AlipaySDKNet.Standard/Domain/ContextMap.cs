using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContextMap Data Structure.
    /// </summary>
    [Serializable]
    public class ContextMap : AopObject
    {
        /// <summary>
        /// key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
