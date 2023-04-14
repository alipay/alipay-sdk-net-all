using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishPrincipalQueryResponse.
    /// </summary>
    public class KoubeiCateringDishPrincipalQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品sku id
        /// </summary>
        [XmlElement("item_sku_id")]
        public string ItemSkuId { get; set; }

        /// <summary>
        /// sku id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
