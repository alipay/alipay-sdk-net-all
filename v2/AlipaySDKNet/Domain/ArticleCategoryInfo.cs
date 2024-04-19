using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArticleCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleCategoryInfo : AopObject
    {
        /// <summary>
        /// 子节点
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("string")]
        public List<string> Children { get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        [XmlElement("father_id")]
        public long FatherId { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
