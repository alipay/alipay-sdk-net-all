using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskTemplateInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskTemplateInfoDTO : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("applet_id")]
        public string AppletId { get; set; }

        /// <summary>
        /// 创建者uid
        /// </summary>
        [XmlElement("creator_uid")]
        public string CreatorUid { get; set; }

        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 出资方类型
        /// </summary>
        [XmlElement("funder_type")]
        public string FunderType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 激励对象： SHOP 门店 MERCHANT 商户 HUNTER 导购员
        /// </summary>
        [XmlElement("incentive")]
        public string Incentive { get; set; }

        /// <summary>
        /// 激励方式： PRESTROKE 逐笔 FIXEDLADDER 固定阶梯 ALGOLADDER 算法阶梯
        /// </summary>
        [XmlElement("incentive_mode")]
        public string IncentiveMode { get; set; }

        /// <summary>
        /// 激励规则
        /// </summary>
        [XmlElement("incentive_rule")]
        public string IncentiveRule { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 活动方名称
        /// </summary>
        [XmlElement("organizer_name")]
        public string OrganizerName { get; set; }

        /// <summary>
        /// 活动方类型
        /// </summary>
        [XmlElement("organizer_type")]
        public string OrganizerType { get; set; }

        /// <summary>
        /// 归属方服务商id
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 招商活动信息
        /// </summary>
        [XmlElement("plan_info")]
        public PlanInfo PlanInfo { get; set; }

        /// <summary>
        /// 任务状态 未发布(UNPUBLISHED) 可发布(PUBLISHABLE) 未开始(NOTSTARTED) 进行中(STARTED) 暂停中(SUSPENDED) 已结束(FINISH)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支持同码激励
        /// </summary>
        [XmlElement("support_unified_material_code")]
        public bool SupportUnifiedMaterialCode { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
