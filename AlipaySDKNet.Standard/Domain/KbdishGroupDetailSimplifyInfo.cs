using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishGroupDetailSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishGroupDetailSimplifyInfo : AopObject
    {
        /// <summary>
        /// 加价
        /// </summary>
        [XmlElement("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 可选组子菜最大可选数量，不传默认为1，传值必须为大于0的数字
        /// </summary>
        [XmlElement("detail_count")]
        public string DetailCount { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部菜品skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 套餐明细规格，default：是否默认；true：默认；false：不默认；cost_inclusive：子菜是否计算入套餐价格内，true：计算，false（默认）：不计算
        /// </summary>
        [XmlElement("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
