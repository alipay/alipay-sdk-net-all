using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductCategoryInfo : AopObject
    {
        /// <summary>
        /// 使用日期，暂不可跨天
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 类别名称。日历型商品使用场地名称例如“五人场A区”，日历型票券商品使用日期例如“1月1日”。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类别唯一ID
        /// </summary>
        [XmlElement("out_category_id")]
        public string OutCategoryId { get; set; }

        /// <summary>
        /// 类别下的区间列表
        /// </summary>
        [XmlArray("zone_list")]
        [XmlArrayItem("product_zone_info")]
        public List<ProductZoneInfo> ZoneList { get; set; }
    }
}
