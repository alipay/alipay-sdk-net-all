using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategorySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategorySaveModel : AopObject
    {
        /// <summary>
        /// 排序菜类列表
        /// </summary>
        [XmlArray("category_entity_list")]
        [XmlArrayItem("dish_category_entity")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
