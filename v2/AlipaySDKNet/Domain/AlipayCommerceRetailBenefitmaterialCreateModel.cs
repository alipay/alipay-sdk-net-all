using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitmaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitmaterialCreateModel : AopObject
    {
        /// <summary>
        /// 素材feeds版URL，feeds已废弃
        /// </summary>
        [XmlElement("activity_material_feeds_url")]
        public string ActivityMaterialFeedsUrl { get; set; }

        /// <summary>
        /// 素材来源
        /// </summary>
        [XmlElement("activity_material_type")]
        public string ActivityMaterialType { get; set; }

        /// <summary>
        /// 素材URL
        /// </summary>
        [XmlElement("activity_material_url")]
        public string ActivityMaterialUrl { get; set; }

        /// <summary>
        /// 素材名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 素材规则
        /// </summary>
        [XmlElement("activity_rule")]
        public string ActivityRule { get; set; }

        /// <summary>
        /// 活动分类
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 素材所属的活动ID
        /// </summary>
        [XmlElement("advertised_activity_id")]
        public string AdvertisedActivityId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 链接信息
        /// </summary>
        [XmlElement("en_info")]
        public string EnInfo { get; set; }

        /// <summary>
        /// 开始时间，传关联的权益（广告）活动的【结束时间】
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 业务来源.业务来源+幂等号确保唯一
        /// </summary>
        [XmlElement("material_source")]
        public string MaterialSource { get; set; }

        /// <summary>
        /// 操作员信息
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 幂等号. 业务来源+幂等号确保唯一
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 投放优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 开始时间，传关联的权益（广告）活动的【开始时间】
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 跳转链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 目标地址类型
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
