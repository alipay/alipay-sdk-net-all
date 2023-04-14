using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishPrincipalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishPrincipalQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型： OUT_DISH_ID_SKU_ID_TO_ITEM_ID_SKU_ID
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 外部菜品id（如星巴克的spu id等）
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部sku id（如星巴克的poskey等）
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
