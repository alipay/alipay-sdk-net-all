using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelPutPlanDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelPutPlanDetailDTO : AopObject
    {
        /// <summary>
        /// 已有活动页面 code
        /// </summary>
        [XmlElement("activity_page")]
        public string ActivityPage { get; set; }

        /// <summary>
        /// 已有活动页面名称
        /// </summary>
        [XmlElement("activity_page_name")]
        public string ActivityPageName { get; set; }

        /// <summary>
        /// 已有活动页面链接
        /// </summary>
        [XmlElement("activity_page_url")]
        public string ActivityPageUrl { get; set; }

        /// <summary>
        /// 活动主标题
        /// </summary>
        [XmlElement("activity_title")]
        public string ActivityTitle { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [XmlElement("bill_way")]
        public string BillWay { get; set; }

        /// <summary>
        /// 渠道 code，渠道信息唯一标识
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 投放计划绑定渠道 id
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 投放计划绑定的渠道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 创建人 id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 人群 id 集合
        /// </summary>
        [XmlArray("crowd_ids")]
        [XmlArrayItem("string")]
        public List<string> CrowdIds { get; set; }

        /// <summary>
        /// 人群信息
        /// </summary>
        [XmlArray("crowd_info")]
        [XmlArrayItem("channel_put_plan_crowd_d_t_o")]
        public List<ChannelPutPlanCrowdDTO> CrowdInfo { get; set; }

        /// <summary>
        /// 自定义活动页面地址
        /// </summary>
        [XmlElement("customize_page")]
        public string CustomizePage { get; set; }

        /// <summary>
        /// 详情页标题
        /// </summary>
        [XmlElement("detail_page_title")]
        public string DetailPageTitle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [XmlElement("gmt_plan_end")]
        public string GmtPlanEnd { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [XmlElement("gmt_plan_start")]
        public string GmtPlanStart { get; set; }

        /// <summary>
        /// 投放计划主键 id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 修改人 id
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 投放计划关联的页面类型
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 列表页展示图
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 投放计划拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 投放描述+不唯一+投放计划修改+数据库获取
        /// </summary>
        [XmlElement("rule_text")]
        public string RuleText { get; set; }

        /// <summary>
        /// 投放计划状态值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 运营增长活动 id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 运营增长活动名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 所属租户 code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
