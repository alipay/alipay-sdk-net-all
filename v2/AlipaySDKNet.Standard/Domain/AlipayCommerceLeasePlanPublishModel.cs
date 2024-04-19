using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLeasePlanPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLeasePlanPublishModel : AopObject
    {
        /// <summary>
        /// 品牌关系标签
        /// </summary>
        [XmlElement("brand_tag")]
        public string BrandTag { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 供给租赁商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
