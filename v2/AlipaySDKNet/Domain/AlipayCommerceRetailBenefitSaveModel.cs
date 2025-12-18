using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitSaveModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// Feeds素材url
        /// </summary>
        [XmlElement("activity_material_feeds_url")]
        public string ActivityMaterialFeedsUrl { get; set; }

        /// <summary>
        /// 默认
        /// </summary>
        [XmlElement("activity_material_type")]
        public string ActivityMaterialType { get; set; }

        /// <summary>
        /// 素材地址
        /// </summary>
        [XmlElement("activity_material_url")]
        public string ActivityMaterialUrl { get; set; }

        /// <summary>
        /// 活动名称，当该字段不传时默认不修改
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动规则
        /// </summary>
        [XmlElement("activity_rule")]
        public string ActivityRule { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("activity_scope_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityScopeList { get; set; }

        /// <summary>
        /// 活动来源，当该字段不传时默认不修改
        /// </summary>
        [XmlElement("activity_source")]
        public string ActivitySource { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 广告ID
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 品牌权益图片
        /// </summary>
        [XmlElement("brand_image")]
        public string BrandImage { get; set; }

        /// <summary>
        /// 品牌logo图片
        /// </summary>
        [XmlElement("brand_logo_image")]
        public string BrandLogoImage { get; set; }

        /// <summary>
        /// 品牌名称，当该字段不传时默认不修改
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("en_info")]
        public string EnInfo { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 操作员信息
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 投放优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("prize_infos")]
        [XmlArrayItem("string")]
        public List<string> PrizeInfos { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 开始时间，当该字段不传时默认不修改
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 端内外url链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// url类型
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
