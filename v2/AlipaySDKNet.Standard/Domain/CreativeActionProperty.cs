using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeActionProperty Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeActionProperty : AopObject
    {
        /// <summary>
        /// 属性C端渲染key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 交互动作属性元素类型，本字段类型限制参考落地页介绍文档
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 属性图片URL； 属性文本值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
