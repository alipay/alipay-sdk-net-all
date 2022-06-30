using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskDetailsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskDetailsInfo : AopObject
    {
        /// <summary>
        /// 参与次数限制
        /// </summary>
        [XmlElement("access_limit_count")]
        public long AccessLimitCount { get; set; }

        /// <summary>
        /// 参与次数限制维度D(天), W(周), M(月), L(终身)
        /// </summary>
        [XmlElement("access_limit_dimension")]
        public string AccessLimitDimension { get; set; }

        /// <summary>
        /// 最近一次累计时间(累计计次的任务需要,非累计计次的就等于lastCompleteTime)
        /// </summary>
        [XmlElement("last_acc_time")]
        public string LastAccTime { get; set; }

        /// <summary>
        /// 最近一次完成时间(已领奖的任务才有)
        /// </summary>
        [XmlElement("last_complete_time")]
        public string LastCompleteTime { get; set; }

        /// <summary>
        /// 最近一次待领奖任务的领奖过期时间(TO_RECEIVE状态的才有)
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
        /// 一个报名周期内当前完成次数(最近报名后累计完成次数,包括发奖成功,发奖阶段失败,和已推荐未领状态) 无需报名就是全部完成次数，等于taskCompleteTimes
        /// </summary>
        [XmlElement("period_current_complete_num")]
        public string PeriodCurrentCompleteNum { get; set; }

        /// <summary>
        /// 一个报名周期内最大完成次数(报名有效点数,单次报名多次发奖)
        /// </summary>
        [XmlElement("period_total_complete_num")]
        public string PeriodTotalCompleteNum { get; set; }

        /// <summary>
        /// 要报名:报名后当前累计周期内有效参与次数,已经过期的参与次数不算 无需报名:当前累计周期内有效参与次数
        /// </summary>
        [XmlElement("periodic_accessed_num")]
        public string PeriodicAccessedNum { get; set; }

        /// <summary>
        /// 累计计次的任务周期的维度
        /// </summary>
        [XmlElement("periodic_dimension")]
        public string PeriodicDimension { get; set; }

        /// <summary>
        /// 任务奖品信息列表
        /// </summary>
        [XmlArray("prize_detail_dto_list")]
        [XmlArrayItem("prize_base_info")]
        public List<PrizeBaseInfo> PrizeDetailDtoList { get; set; }

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
        /// 任务当次参与完成状态:未报名,已失效,已取消,部分完成(需要累计计次的任务),已完成待领奖,已领奖
        /// </summary>
        [XmlElement("task_process_status")]
        public string TaskProcessStatus { get; set; }

        /// <summary>
        /// 任务咨询后有效奖品列表
        /// </summary>
        [XmlElement("valid_prize_detail_dto")]
        public PrizeBaseInfo ValidPrizeDetailDto { get; set; }
    }
}
