using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualdishQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店下虚拟类目下的菜品id列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("kbdish_virtual_dish_info")]
        public List<KbdishVirtualDishInfo> DishList { get; set; }

        /// <summary>
        /// 口碑侧门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
