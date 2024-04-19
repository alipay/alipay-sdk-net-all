using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInstanceBasicInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInstanceBasicInfoDTO : AopObject
    {
        /// <summary>
        /// 任务完成时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 已发放激励数量，单位分
        /// </summary>
        [XmlElement("published_amount")]
        public string PublishedAmount { get; set; }

        /// <summary>
        /// 任务领取时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 任务实例状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

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

        /// <summary>
        /// 任务最大激励现金，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
