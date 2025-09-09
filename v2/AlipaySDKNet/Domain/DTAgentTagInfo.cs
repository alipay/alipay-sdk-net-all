using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentTagInfo : AopObject
    {
        /// <summary>
        /// 标签类型，枚举值
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 指定标签类型对应的具体标签值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
