using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskFullInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskFullInfo : AopObject
    {
        /// <summary>
        /// 参与次数限制
        /// </summary>
        [XmlElement("access_limit_count")]
        public long AccessLimitCount { get; set; }

        /// <summary>
        /// 最近一次累计时间
        /// </summary>
        [XmlElement("last_acc_time")]
        public string LastAccTime { get; set; }

        /// <summary>
        /// 最近一次完成时间(已领奖的任务才有)
        /// </summary>
        [XmlElement("last_complete_time")]
        public string LastCompleteTime { get; set; }

        /// <summary>
        /// 最近一次待领奖任务的领奖过期时间
        /// </summary>
        [XmlElement("last_receive_expire_time")]
        public string LastReceiveExpireTime { get; set; }

        /// <summary>
        /// 最近一次报名过期时间
        /// </summary>
        [XmlElement("last_signup_expire_time")]
        public string LastSignupExpireTime { get; set; }

        /// <summary>
        /// 最近一次报名时间
        /// </summary>
        [XmlElement("last_signup_time")]
        public string LastSignupTime { get; set; }

        /// <summary>
        /// 是否需要报名
        /// </summary>
        [XmlElement("need_sign_up")]
        public bool NeedSignUp { get; set; }

        /// <summary>
        /// 一个报名周期内当前完成次数
        /// </summary>
        [XmlElement("period_current_complete_num")]
        public long PeriodCurrentCompleteNum { get; set; }

        /// <summary>
        /// 一个报名周期内最大完成次数
        /// </summary>
        [XmlElement("period_total_complete_num")]
        public long PeriodTotalCompleteNum { get; set; }

        /// <summary>
        /// 要报名:报名后当前累计周期内有效参与次数...
        /// </summary>
        [XmlElement("periodic_accessed_num")]
        public long PeriodicAccessedNum { get; set; }

        /// <summary>
        /// 累计计次的任务周期的维度
        /// </summary>
        [XmlElement("periodic_dimension")]
        public string PeriodicDimension { get; set; }

        /// <summary>
        /// 任务奖品信息列表
        /// </summary>
        [XmlArray("prize_detail_list")]
        [XmlArrayItem("prize_base_info")]
        public List<PrizeBaseInfo> PrizeDetailList { get; set; }

        /// <summary>
        /// 领奖触发方式
        /// </summary>
        [XmlElement("send_camp_trigger_type")]
        public string SendCampTriggerType { get; set; }

        /// <summary>
        /// 任务基本配置信息
        /// </summary>
        [XmlElement("task_base_info")]
        public TaskBaseInfo TaskBaseInfo { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务属性
        /// </summary>
        [XmlElement("task_material")]
        public TaskMaterialInfo TaskMaterial { get; set; }

        /// <summary>
        /// 任务当次参与完成状态:未报名,已失效,已...
        /// </summary>
        [XmlElement("task_process_status")]
        public string TaskProcessStatus { get; set; }

        /// <summary>
        /// 任务咨询后有效奖品列表
        /// </summary>
        [XmlArray("valid_prize_list")]
        [XmlArrayItem("prize_base_info")]
        public List<PrizeBaseInfo> ValidPrizeList { get; set; }
    }
}
