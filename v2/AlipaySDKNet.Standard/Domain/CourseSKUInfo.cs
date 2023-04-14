using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CourseSKUInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CourseSKUInfo : AopObject
    {
        /// <summary>
        /// 课程数量
        /// </summary>
        [XmlElement("course_num")]
        public long CourseNum { get; set; }

        /// <summary>
        /// 现价(单位 : 分)
        /// </summary>
        [XmlElement("cur_price")]
        public long CurPrice { get; set; }

        /// <summary>
        /// 原价(单位 : 分)
        /// </summary>
        [XmlElement("ori_price")]
        public long OriPrice { get; set; }

        /// <summary>
        /// 外部skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
