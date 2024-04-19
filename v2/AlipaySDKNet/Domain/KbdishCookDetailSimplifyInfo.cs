using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCookDetailSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookDetailSimplifyInfo : AopObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 菜品在菜谱中的售卖时间，同一个out_dish_id都指定的情况下 以第一个为准
        /// </summary>
        [XmlArray("time_ranges")]
        [XmlArrayItem("string")]
        public List<string> TimeRanges { get; set; }
    }
}
