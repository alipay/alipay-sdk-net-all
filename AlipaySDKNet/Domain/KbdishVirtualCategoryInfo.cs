using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishVirtualCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishVirtualCategoryInfo : AopObject
    {
        /// <summary>
        /// 虚拟类目id
        /// </summary>
        [XmlElement("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 口碑菜品列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("kb_virtual_shop_category_dish_info")]
        public List<KbVirtualShopCategoryDishInfo> DishList { get; set; }
    }
}
