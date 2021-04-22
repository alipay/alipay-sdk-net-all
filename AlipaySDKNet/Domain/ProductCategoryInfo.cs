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
        /// 类别名称
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
