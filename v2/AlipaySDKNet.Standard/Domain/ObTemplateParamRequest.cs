using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObTemplateParamRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObTemplateParamRequest : AopObject
    {
        /// <summary>
        /// 描述字段类型的关键字
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// map中value的描述
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
