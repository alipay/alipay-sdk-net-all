using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑菜品模型列表
        /// </summary>
        [XmlArray("kb_dish_info_list")]
        [XmlArrayItem("kbdish_info")]
        public List<KbdishInfo> KbDishInfoList { get; set; }
    }
}
