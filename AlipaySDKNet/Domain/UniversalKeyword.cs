using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniversalKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class UniversalKeyword : AopObject
    {
        /// <summary>
        /// 沟通平台动态字段映射字段名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 沟通平台动态字段映射字段值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
