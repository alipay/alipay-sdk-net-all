using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FillContent Data Structure.
    /// </summary>
    [Serializable]
    public class FillContent : AopObject
    {
        /// <summary>
        /// 模板组件自定义key
        /// </summary>
        [XmlElement("struct_key")]
        public string StructKey { get; set; }

        /// <summary>
        /// 模板值,该值长度取决于配置模板时该字段的限制
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
