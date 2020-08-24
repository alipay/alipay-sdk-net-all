using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppletTaskVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppletTaskVO : AopObject
    {
        /// <summary>
        /// 是否可以报名
        /// </summary>
        [XmlElement("can_access")]
        public bool CanAccess { get; set; }

        /// <summary>
        /// 任务显示信息。
        /// </summary>
        [XmlElement("display")]
        public AppletTaskDisplayVO Display { get; set; }

        /// <summary>
        /// 是否需要报名
        /// </summary>
        [XmlElement("need_sign_up")]
        public string NeedSignUp { get; set; }

        /// <summary>
        /// 报名周期内当前完成次数
        /// </summary>
        [XmlElement("period_current_complete_num")]
        public long PeriodCurrentCompleteNum { get; set; }

        /// <summary>
        /// 报名周期内最大完成次数
        /// </summary>
        [XmlElement("period_total_complete_num")]
        public long PeriodTotalCompleteNum { get; set; }

        /// <summary>
        /// 任务奖品。
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("applet_task_prize_v_o")]
        public List<AppletTaskPrizeVO> PrizeList { get; set; }

        /// <summary>
        /// 报名开始时间。
        /// </summary>
        [XmlElement("sign_up_begin_time")]
        public string SignUpBeginTime { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [XmlElement("sign_up_end_time")]
        public string SignUpEndTime { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务状态。NONE_SIGNUP未报名/SIGNUP_EXPIRED报名已失效/PARTLY_DONE未完成/RECEIVE_SUCCESS领奖成功/RECEIVE_FAILED领奖失败/RECEIVE_EXPIRED过期未领奖/SIGNUP_FAILED报名失败/SIGNUP_CANCELED报名已取消/NOT_DONE无需报名的任务未开始
        /// </summary>
        [XmlElement("task_process_status")]
        public string TaskProcessStatus { get; set; }
    }
}
