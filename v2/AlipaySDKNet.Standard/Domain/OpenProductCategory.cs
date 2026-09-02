using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenProductCategory Data Structure.
    /// </summary>
    [Serializable]
    public class OpenProductCategory : AopObject
    {
        /// <summary>
        /// 生态侧的类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 生态侧类目对应的名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [XmlElement("leaf")]
        public bool Leaf { get; set; }

        /// <summary>
        /// 类目的层级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 父目录ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
