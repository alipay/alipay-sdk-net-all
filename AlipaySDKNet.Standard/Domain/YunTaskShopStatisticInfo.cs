using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskShopStatisticInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskShopStatisticInfo : AopObject
    {
        /// <summary>
        /// 任务总领取数
        /// </summary>
        [XmlElement("received_number")]
        public long ReceivedNumber { get; set; }

        /// <summary>
        /// 任务模板状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

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
        /// 标的物总完成数
        /// </summary>
        [XmlElement("total_marker_amount")]
        public long TotalMarkerAmount { get; set; }

        /// <summary>
        /// 总发放积分数量
        /// </summary>
        [XmlElement("total_point_amount")]
        public long TotalPointAmount { get; set; }

        /// <summary>
        /// 总目标数
        /// </summary>
        [XmlElement("total_target_point")]
        public long TotalTargetPoint { get; set; }
    }
}
