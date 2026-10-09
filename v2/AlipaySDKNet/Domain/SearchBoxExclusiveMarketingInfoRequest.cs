using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxExclusiveMarketingInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxExclusiveMarketingInfoRequest : AopObject
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 活动类型，MARETING/营销活动、MEMBERSHIP/开卡活动、CUSTOM/自定义活动
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 活动链接
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        [XmlElement("applier_id")]
        public string ApplierId { get; set; }

        /// <summary>
        /// 品牌boxid
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 活动工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材链接
        /// </summary>
        [XmlElement("material_link")]
        public string MaterialLink { get; set; }

        /// <summary>
        /// 素材类型 IMAGE/VIDEO(图片/视频)
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 定向规则
        /// </summary>
        [XmlElement("oriented_rules")]
        public SearchProductOrientedRuleOpenApi OrientedRules { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("serv_code")]
        public string ServCode { get; set; }

        /// <summary>
        /// 目标时段，包括全天的时段和全年的时段
        /// </summary>
        [XmlElement("target_period")]
        public SearchProductPeriod TargetPeriod { get; set; }

        /// <summary>
        /// 目标区域，为list，元素为区域模型标识区域类型和具体区域
        /// </summary>
        [XmlArray("target_region")]
        [XmlArrayItem("search_product_region")]
        public List<SearchProductRegion> TargetRegion { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
