using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LmCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class LmCategoryVO : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 是否叶子类目
        /// </summary>
        [XmlElement("leaf")]
        public bool Leaf { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前类目的父类目id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
