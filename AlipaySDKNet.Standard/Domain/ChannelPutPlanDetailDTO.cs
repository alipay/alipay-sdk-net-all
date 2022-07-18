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
        /// 自定义活动页面地址
        /// </summary>
        [XmlElement("activity_page")]
        public string ActivityPage { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [XmlElement("bill_way")]
        public string BillWay { get; set; }

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
        /// 自定义活动页面地址
        /// </summary>
        [XmlElement("customize_page")]
        public string CustomizePage { get; set; }

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
        /// 投放计划拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

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
