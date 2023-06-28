using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInstanceRewardInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInstanceRewardInfoDTO : AopObject
    {
        /// <summary>
        /// 当前进度
        /// </summary>
        [XmlElement("current_num")]
        public long CurrentNum { get; set; }

        /// <summary>
        /// 任务推广达成时间
        /// </summary>
        [XmlElement("guided_finish_time")]
        public string GuidedFinishTime { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 任务已发放激励金额，单位元
        /// </summary>
        [XmlElement("published_amount")]
        public string PublishedAmount { get; set; }

        /// <summary>
        /// 任务领取时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 任务总进度
        /// </summary>
        [XmlElement("target_num")]
        public string TargetNum { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务最大激励金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
