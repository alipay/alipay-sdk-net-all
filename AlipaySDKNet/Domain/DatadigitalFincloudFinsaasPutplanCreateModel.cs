using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasPutplanCreateModel : AopObject
    {
        /// <summary>
        /// 已有页面地址
        /// </summary>
        [XmlElement("activity_page")]
        public string ActivityPage { get; set; }

        /// <summary>
        /// 活动主标题
        /// </summary>
        [XmlElement("activity_title")]
        public string ActivityTitle { get; set; }

        /// <summary>
        /// 权益描述内容
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [XmlElement("bill_way")]
        public string BillWay { get; set; }

        /// <summary>
        /// 渠道 id
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

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
        /// 人群 id 列表，多个英文逗号分隔
        /// </summary>
        [XmlElement("crowd_ids")]
        public string CrowdIds { get; set; }

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
        /// 投放计划结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 投放页面类型
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 列表页展示图
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 投放内容
        /// </summary>
        [XmlElement("plan_content")]
        public string PlanContent { get; set; }

        /// <summary>
        /// 展示用规则文本
        /// </summary>
        [XmlElement("rule_text")]
        public string RuleText { get; set; }

        /// <summary>
        /// 投放计划开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 运营增长任务 id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 租户 code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
