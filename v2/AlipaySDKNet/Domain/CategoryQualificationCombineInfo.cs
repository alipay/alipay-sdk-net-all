using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryQualificationCombineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryQualificationCombineInfo : AopObject
    {
        /// <summary>
        /// 资质列表
        /// </summary>
        [XmlArray("qualification_list")]
        [XmlArrayItem("category_qualification_info")]
        public List<CategoryQualificationInfo> QualificationList { get; set; }

        /// <summary>
        /// 关联类目列表
        /// </summary>
        [XmlArray("rel_category_list")]
        [XmlArrayItem("group_purchase_category_info")]
        public List<GroupPurchaseCategoryInfo> RelCategoryList { get; set; }
    }
}
