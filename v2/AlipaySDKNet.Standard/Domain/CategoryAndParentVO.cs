using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryAndParentVO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryAndParentVO : AopObject
    {
        /// <summary>
        /// 叶子类目与它的父类目
        /// </summary>
        [XmlArray("cat_and_parent")]
        [XmlArrayItem("appx_category_v_o")]
        public List<AppxCategoryVO> CatAndParent { get; set; }
    }
}
