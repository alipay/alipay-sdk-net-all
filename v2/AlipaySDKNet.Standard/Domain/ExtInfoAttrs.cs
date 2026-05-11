using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtInfoAttrs Data Structure.
    /// </summary>
    [Serializable]
    public class ExtInfoAttrs : AopObject
    {
        /// <summary>
        /// 扩展信息key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展信息value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
