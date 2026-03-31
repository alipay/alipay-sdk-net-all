using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Agentproperties Data Structure.
    /// </summary>
    [Serializable]
    public class Agentproperties : AopObject
    {
        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
