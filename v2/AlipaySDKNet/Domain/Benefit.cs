using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Benefit Data Structure.
    /// </summary>
    [Serializable]
    public class Benefit : AopObject
    {
        /// <summary>
        /// 保险的具体描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 保险
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 权益的类型，比如保险
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
