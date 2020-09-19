using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishQuerydishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishQuerydishQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜品信息
        /// </summary>
        [XmlArray("dish_info_list")]
        [XmlArrayItem("kbdish_simply_info")]
        public List<KbdishSimplyInfo> DishInfoList { get; set; }

        /// <summary>
        /// 是否需要重试，true：是；false：不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
