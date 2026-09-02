using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HeaderParam Data Structure.
    /// </summary>
    [Serializable]
    public class HeaderParam : AopObject
    {
        /// <summary>
        /// 参数名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
