using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FollowupCreateContext Data Structure.
    /// </summary>
    [Serializable]
    public class FollowupCreateContext : AopObject
    {
        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("candidate_name")]
        public string CandidateName { get; set; }

        /// <summary>
        /// 候选人手机号
        /// </summary>
        [XmlElement("candidate_phone")]
        public string CandidatePhone { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company")]
        public string Company { get; set; }

        /// <summary>
        /// 仓储分拣
        /// </summary>
        [XmlElement("job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 跟进环节标识
        /// </summary>
        [XmlElement("stage_key")]
        public string StageKey { get; set; }

        /// <summary>
        /// 任务截止时间
        /// </summary>
        [XmlElement("task_deadline")]
        public string TaskDeadline { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [XmlElement("work_location")]
        public string WorkLocation { get; set; }

        /// <summary>
        /// 上工时间
        /// </summary>
        [XmlElement("work_time")]
        public string WorkTime { get; set; }
    }
}
