using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitCreateModel : AopObject
    {
        /// <summary>
        /// 广告投放活动
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
        /// 活动来源
        /// </summary>
        [XmlElement("activity_source")]
        public string ActivitySource { get; set; }

        /// <summary>
        /// 活动分类
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 品牌Logo图片
        /// </summary>
        [XmlElement("brand_logo_image")]
        public string BrandLogoImage { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("en_info")]
        public string EnInfo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 投放人员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 幂等号，要保证唯一
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 投放优先级，数字越大，越优先投放
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
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
