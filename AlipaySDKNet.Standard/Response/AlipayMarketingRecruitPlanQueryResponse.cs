using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingRecruitPlanQueryResponse.
    /// </summary>
    public class AlipayMarketingRecruitPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 招商方案描述：富文本内容，可能包含html标签
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [XmlElement("enroll_end_time")]
        public string EnrollEndTime { get; set; }

        /// <summary>
        /// 招商报名规则
        /// </summary>
        [XmlArray("enroll_rules")]
        [XmlArrayItem("recruit_enroll_rule")]
        public List<RecruitEnrollRule> EnrollRules { get; set; }

        /// <summary>
        /// 报名开始时间
        /// </summary>
        [XmlElement("enroll_start_time")]
        public string EnrollStartTime { get; set; }

        /// <summary>
        /// 方案头图链接，150x150 以上尺寸的方形图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商方案名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 方案状态: 不可用:DISABLED;可用:ENABLED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
