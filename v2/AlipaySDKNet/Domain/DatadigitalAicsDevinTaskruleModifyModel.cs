using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinTaskruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinTaskruleModifyModel : AopObject
    {
        /// <summary>
        /// 是否启用：0-开启 1-关闭
        /// </summary>
        [XmlElement("enable_flag")]
        public long EnableFlag { get; set; }

        /// <summary>
        /// 失效时间，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 定时任务执行时间区间(结束)，格式HH:mm
        /// </summary>
        [XmlElement("schedule_end_time")]
        public string ScheduleEndTime { get; set; }

        /// <summary>
        /// 定时任务执行区间(开始)，格式HH:mm
        /// </summary>
        [XmlElement("schedule_start_time")]
        public string ScheduleStartTime { get; set; }

        /// <summary>
        /// 生效时间，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("take_effect_time")]
        public string TakeEffectTime { get; set; }

        /// <summary>
        /// 规则编码（定位待更新规则的唯一键）
        /// </summary>
        [XmlElement("task_rules_code")]
        public string TaskRulesCode { get; set; }

        /// <summary>
        /// 任务规则详情(JSON字符串，含timeZone/scheduleTimeRange等)
        /// </summary>
        [XmlElement("task_rules_detail")]
        public string TaskRulesDetail { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("task_rules_name")]
        public string TaskRulesName { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
