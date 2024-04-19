using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishEstimateQueryResponse.
    /// </summary>
    public class KoubeiCateringDishEstimateQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜品估清信息
        /// </summary>
        [XmlArray("dish_info_list")]
        [XmlArrayItem("estimate_dish_info")]
        public List<EstimateDishInfo> DishInfoList { get; set; }

        /// <summary>
        /// 失败下是否可以重试，true：需要；false：不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
