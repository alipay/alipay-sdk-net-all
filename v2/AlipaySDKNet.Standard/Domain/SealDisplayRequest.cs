using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SealDisplayRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SealDisplayRequest : AopObject
    {
        /// <summary>
        /// 展示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 节点类型  text：普通文本；href ：超链接
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 链接地址 可空，当type为href时使用
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 属性value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
