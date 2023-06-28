using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaoKeTaskTemplateInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaoKeTaskTemplateInfoDTO : AopObject
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("applet_id")]
        public string AppletId { get; set; }

        /// <summary>
        /// 创建者的uid
        /// </summary>
        [XmlElement("creator_uid")]
        public string CreatorUid { get; set; }

        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 赞助者类型
        /// </summary>
        [XmlElement("funder_type")]
        public string FunderType { get; set; }

        /// <summary>
        /// 激励对象： HUNTER 导购员
        /// </summary>
        [XmlElement("incentive")]
        public string Incentive { get; set; }

        /// <summary>
        /// 激励方式： REALAMOUNT_RATIO购买金额比例
        /// </summary>
        [XmlElement("incentive_mode")]
        public string IncentiveMode { get; set; }

        /// <summary>
        /// 激励规则
        /// </summary>
        [XmlElement("incentive_rule")]
        public RealAmountRatioIncentiveRule IncentiveRule { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 活动方类型
        /// </summary>
        [XmlElement("organizer_type")]
        public string OrganizerType { get; set; }

        /// <summary>
        /// 归属方的id
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务失效时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务模板生效时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务模板id
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
