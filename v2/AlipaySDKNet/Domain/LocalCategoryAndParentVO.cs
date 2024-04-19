using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalCategoryAndParentVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocalCategoryAndParentVO : AopObject
    {
        /// <summary>
        /// 叶子类目与它的父类目
        /// </summary>
        [XmlArray("cat_and_parent")]
        [XmlArrayItem("local_appx_category_v_o")]
        public List<LocalAppxCategoryVO> CatAndParent { get; set; }
    }
}
