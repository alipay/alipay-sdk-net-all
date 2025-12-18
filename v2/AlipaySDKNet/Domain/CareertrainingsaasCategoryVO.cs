using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CareertrainingsaasCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class CareertrainingsaasCategoryVO : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("category_level")]
        public long CategoryLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目父id
        /// </summary>
        [XmlElement("category_parent_id")]
        public long CategoryParentId { get; set; }

        /// <summary>
        /// 类目排序
        /// </summary>
        [XmlElement("category_sort")]
        public long CategorySort { get; set; }
    }
}
