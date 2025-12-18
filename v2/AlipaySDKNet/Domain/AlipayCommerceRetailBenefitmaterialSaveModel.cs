using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitmaterialSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitmaterialSaveModel : AopObject
    {
        /// <summary>
        /// 素材feeds版URL，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("activity_material_feeds_url")]
        public string ActivityMaterialFeedsUrl { get; set; }

        /// <summary>
        /// 素材来源，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("activity_material_type")]
        public string ActivityMaterialType { get; set; }

        /// <summary>
        /// 素材URL，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("activity_material_url")]
        public string ActivityMaterialUrl { get; set; }

        /// <summary>
        /// 素材名称， 字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 素材规则
        /// </summary>
        [XmlElement("activity_rule")]
        public string ActivityRule { get; set; }

        /// <summary>
        /// 活动类型，不定传MATERIAL_ADVERTISEMENT
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 品牌名称，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 链接信息，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("en_info")]
        public string EnInfo { get; set; }

        /// <summary>
        /// 结束时间，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("material_source")]
        public string MaterialSource { get; set; }

        /// <summary>
        /// 操作者信息
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 优先级， 字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 备注字段，描述本次修改的内容
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 开始时间，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 目标地址，字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 目标地址类型， 字段为空意味着不修改该字段
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
