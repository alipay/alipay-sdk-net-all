using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsCategoryResult Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsCategoryResult : AopObject
    {
        /// <summary>
        /// 类目code，格式：多级通过|(英文竖线相隔)
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 当前类目层级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 父节点类目code
        /// </summary>
        [XmlElement("parent_category_code")]
        public string ParentCategoryCode { get; set; }
    }
}
