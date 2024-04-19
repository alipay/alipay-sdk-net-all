using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosCategorylistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategorylistQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜类列表
        /// </summary>
        [XmlArray("category_entity_list")]
        [XmlArrayItem("dish_category_entity")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
