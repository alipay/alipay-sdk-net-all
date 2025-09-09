using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 待查询的类目id列表
        /// </summary>
        [XmlArray("category_ids")]
        [XmlArrayItem("number")]
        public List<long> CategoryIds { get; set; }

        /// <summary>
        /// 父类目id，返回父类目的所有子类目信息
        /// </summary>
        [XmlElement("parent_category_id")]
        public long ParentCategoryId { get; set; }
    }
}
