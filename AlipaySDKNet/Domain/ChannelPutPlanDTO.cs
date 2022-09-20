using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelPutPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelPutPlanDTO : AopObject
    {
        /// <summary>
        /// 已有活动页面地址
        /// </summary>
        [XmlElement("activity_page")]
        public string ActivityPage { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [XmlElement("bill_way")]
        public string BillWay { get; set; }

        /// <summary>
        /// 渠道关联业务 id，比如运营活动 id 一期回填的是运营增长活动 id V1.1 版本开始废弃
        /// </summary>
        [XmlElement("channel_biz_id")]
        public long ChannelBizId { get; set; }

        /// <summary>
        /// 渠道关联业务 id，比如运营活动 id 一期回填的是运营增长活动 id
        /// </summary>
        [XmlElement("channel_biz_id_str")]
        public string ChannelBizIdStr { get; set; }

        /// <summary>
        /// 渠道类别+不唯一+租户渠道列表查询+数据库
        /// </summary>
        [XmlElement("channel_categorychannel_category")]
        public string ChannelCategorychannelCategory { get; set; }

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
        /// 人群ids,用,分隔人群id
        /// </summary>
        [XmlElement("crowd_ids")]
        public string CrowdIds { get; set; }

        /// <summary>
        /// 自定义页面地址
        /// </summary>
        [XmlElement("customize_page")]
        public string CustomizePage { get; set; }

        /// <summary>
        /// 计划实际执行结束时间
        /// </summary>
        [XmlElement("exc_end_time")]
        public string ExcEndTime { get; set; }

        /// <summary>
        /// 投放计划实际执行时间
        /// </summary>
        [XmlElement("exc_start_time")]
        public string ExcStartTime { get; set; }

        /// <summary>
        /// 异常原因
        /// </summary>
        [XmlElement("exception_reason")]
        public string ExceptionReason { get; set; }

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
        /// 主键 id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 更新人 id
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页面类型
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 投放内容，动态json
        /// </summary>
        [XmlElement("plan_content")]
        public string PlanContent { get; set; }

        /// <summary>
        /// 计划来源
        /// </summary>
        [XmlElement("plan_source")]
        public string PlanSource { get; set; }

        /// <summary>
        /// 审核拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [XmlElement("repeat_times")]
        public long RepeatTimes { get; set; }

        /// <summary>
        /// 投放计划状态值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户 code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
