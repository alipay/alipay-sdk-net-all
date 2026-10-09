using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 推荐菜品列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("dish_recommend")]
        public List<DishRecommend> DishList { get; set; }
    }
}
