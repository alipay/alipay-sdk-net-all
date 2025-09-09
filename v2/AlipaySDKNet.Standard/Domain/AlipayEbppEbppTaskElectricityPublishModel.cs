using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppTaskElectricityPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppTaskElectricityPublishModel : AopObject
    {
        /// <summary>
        /// 任务结束响应时间，精确到秒
        /// </summary>
        [XmlElement("active_end_time")]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// 任务开始响应时间
        /// </summary>
        [XmlElement("active_start_time")]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// 是否有奖励
        /// </summary>
        [XmlElement("have_reward")]
        public string HaveReward { get; set; }

        /// <summary>
        /// 演练
        /// </summary>
        [XmlElement("is_test")]
        public string IsTest { get; set; }

        /// <summary>
        /// 电科院任务id
        /// </summary>
        [XmlElement("out_task_id")]
        public string OutTaskId { get; set; }

        /// <summary>
        /// 任务规则描述
        /// </summary>
        [XmlElement("rule_info")]
        public string RuleInfo { get; set; }

        /// <summary>
        /// 户号或供电单位编号
        /// </summary>
        [XmlElement("task_active_data")]
        public string TaskActiveData { get; set; }

        /// <summary>
        /// 执行范围-01 供电单位代码、02 户号
        /// </summary>
        [XmlElement("task_active_range")]
        public string TaskActiveRange { get; set; }

        /// <summary>
        /// 削峰填谷，单位为Kw
        /// </summary>
        [XmlElement("task_active_target")]
        public string TaskActiveTarget { get; set; }

        /// <summary>
        /// 任务编号，电科院下发任务编号
        /// </summary>
        [XmlElement("task_event_no")]
        public string TaskEventNo { get; set; }

        /// <summary>
        /// 任务截止报名时间
        /// </summary>
        [XmlElement("task_join_limit_time")]
        public string TaskJoinLimitTime { get; set; }

        /// <summary>
        /// 省码
        /// </summary>
        [XmlElement("task_province_code")]
        public string TaskProvinceCode { get; set; }

        /// <summary>
        /// 任务响应级别：0：分钟级 1：小时级 2：日前级
        /// </summary>
        [XmlElement("task_response_level")]
        public string TaskResponseLevel { get; set; }

        /// <summary>
        /// 任务类型：01-削峰 02-填谷 03-温控
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 温控任务指标，当任务类型是03时，必填，精确到千瓦时
        /// </summary>
        [XmlElement("tempreture_active_data")]
        public string TempretureActiveData { get; set; }
    }
}
