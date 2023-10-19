using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskStatusInfo : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 报名后完成发奖次数(需报名任务)
        /// </summary>
        [XmlElement("complete_count")]
        public long CompleteCount { get; set; }

        /// <summary>
        /// 完成发奖时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 任务进度
        /// </summary>
        [XmlElement("periodic_acc_count")]
        public long PeriodicAccCount { get; set; }

        /// <summary>
        /// 领奖过期时间(需用户主动领奖任务)
        /// </summary>
        [XmlElement("receive_expire_time")]
        public string ReceiveExpireTime { get; set; }

        /// <summary>
        /// 报名过期时间
        /// </summary>
        [XmlElement("signup_expire_time")]
        public string SignupExpireTime { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        [XmlElement("signup_time")]
        public string SignupTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子状态（由业务自定义）
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
