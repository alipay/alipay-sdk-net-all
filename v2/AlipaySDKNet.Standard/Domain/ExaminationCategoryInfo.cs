using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationCategoryInfo : AopObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目状态
        /// </summary>
        [XmlElement("category_state")]
        public string CategoryState { get; set; }

        /// <summary>
        /// 类目类型， 检查类目类型:CHECK_CATEGORY、 检验类目类型：INSPECTION_CATEGORY 不传，默认查全部
        /// </summary>
        [XmlElement("category_type")]
        public string CategoryType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("children_list")]
        [XmlArrayItem("examination_second_category_info")]
        public List<ExaminationSecondCategoryInfo> ChildrenList { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [XmlElement("is_leaf")]
        public long IsLeaf { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 父类目id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
