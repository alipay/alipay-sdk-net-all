using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishQuerydishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishQuerydishQueryModel : AopObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部门店id，必填逻辑为：与口碑门店id二选一；当菜为门店菜时必须传门店id，否则查询不到菜品。
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
