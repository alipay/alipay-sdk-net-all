using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动规则
        /// </summary>
        [XmlElement("activity_rule")]
        public string ActivityRule { get; set; }

        /// <summary>
        /// 活动规则描述
        /// </summary>
        [XmlElement("activity_rule_desc")]
        public string ActivityRuleDesc { get; set; }

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
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

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
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动status
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("verify_tester")]
        [XmlArrayItem("string")]
        public List<string> VerifyTester { get; set; }
    }
}
