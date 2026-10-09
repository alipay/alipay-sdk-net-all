using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTaskSimpleDto Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskSimpleDto : AopObject
    {
        /// <summary>
        /// 服务商额外配置信息
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 用户任务完成的北京时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// 任务计数信息
        /// </summary>
        [XmlElement("counting_info")]
        public UserTaskCountingDto CountingInfo { get; set; }

        /// <summary>
        /// 任务子节点任务列表
        /// </summary>
        [XmlArray("node_task_list")]
        [XmlArrayItem("user_node_task_simple_dto")]
        public List<UserNodeTaskSimpleDto> NodeTaskList { get; set; }

        /// <summary>
        /// 用户任务外部ID
        /// </summary>
        [XmlElement("out_user_task_id")]
        public string OutUserTaskId { get; set; }

        /// <summary>
        /// 权益规则信息
        /// </summary>
        [XmlArray("rights_rule_list")]
        [XmlArrayItem("task_rights_rule_dto")]
        public List<TaskRightsRuleDto> RightsRuleList { get; set; }

        /// <summary>
        /// 数字越小越靠前，默认为0
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 任务周期，YEAR - 年，MONTH - 月，WEEK -周，DAILY -日，NO_CYCLE -无周期,DYNAMIC_DAYS -动态天
        /// </summary>
        [XmlElement("task_cycle")]
        public string TaskCycle { get; set; }

        /// <summary>
        /// 任务周期内可完成的次数,默认1,0代表周期内可完成无数次
        /// </summary>
        [XmlElement("task_cycle_complete_count")]
        public long TaskCycleCompleteCount { get; set; }

        /// <summary>
        /// 任务周期内动态周期数值。动态天周期就代表动态几天
        /// </summary>
        [XmlElement("task_cycle_dynamic_count")]
        public long TaskCycleDynamicCount { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务图片链接
        /// </summary>
        [XmlElement("task_image_url")]
        public string TaskImageUrl { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务节点。NONE：普通节点，PARENT：父节点，CHILD：子节点
        /// </summary>
        [XmlElement("task_node")]
        public string TaskNode { get; set; }

        /// <summary>
        /// 任务去完成的跳转链接
        /// </summary>
        [XmlElement("task_url")]
        public string TaskUrl { get; set; }

        /// <summary>
        /// 用户任务ID
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }

        /// <summary>
        /// 用户任务权益列表
        /// </summary>
        [XmlArray("user_task_rights_list")]
        [XmlArrayItem("user_task_rights_simple_dto")]
        public List<UserTaskRightsSimpleDto> UserTaskRightsList { get; set; }

        /// <summary>
        /// NOT_APPLY：任务未领取 TODO：任务未完成 COMPLETED：任务已完成 RECEIVED：任务权益已领取，STOPED：已终止
        /// </summary>
        [XmlElement("user_task_status")]
        public string UserTaskStatus { get; set; }
    }
}
