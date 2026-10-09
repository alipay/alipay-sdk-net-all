using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppxCategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppxCategoryVO : AopObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [XmlElement("cat_id")]
        public string CatId { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("cat_level")]
        public long CatLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 仅叶子节点有类目状态
        /// </summary>
        [XmlElement("cat_status")]
        public string CatStatus { get; set; }

        /// <summary>
        /// 父类目编号
        /// </summary>
        [XmlElement("f_cat_id")]
        public string FCatId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlArray("item_types")]
        [XmlArrayItem("string")]
        public List<string> ItemTypes { get; set; }

        /// <summary>
        /// 开通状态。只有叶子结点有开通状态 当前字段已废弃(请参考cat_status字段获取当前类目的资质状态以及邀约状态等)
        /// </summary>
        [XmlElement("qualification_status")]
        public string QualificationStatus { get; set; }
    }
}
