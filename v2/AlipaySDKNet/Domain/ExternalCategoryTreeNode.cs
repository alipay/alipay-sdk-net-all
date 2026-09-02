using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalCategoryTreeNode Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalCategoryTreeNode : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [XmlElement("leaf")]
        public bool Leaf { get; set; }

        /// <summary>
        /// 父类目ID
        /// </summary>
        [XmlElement("parent_cate_id")]
        public string ParentCateId { get; set; }
    }
}
