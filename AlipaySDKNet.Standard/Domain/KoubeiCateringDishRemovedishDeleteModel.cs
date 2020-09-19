using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishRemovedishDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishRemovedishDeleteModel : AopObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部门店id，口碑门店id和外部门店id二选一必填
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 菜品skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
