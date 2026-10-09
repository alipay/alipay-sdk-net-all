using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜类信息
        /// </summary>
        [XmlElement("dish_category_entity")]
        public DishCategoryEntity DishCategoryEntity { get; set; }
    }
}
