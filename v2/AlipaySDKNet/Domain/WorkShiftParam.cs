using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkShiftParam Data Structure.
    /// </summary>
    [Serializable]
    public class WorkShiftParam : AopObject
    {
        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 排班优化类型
        /// </summary>
        [XmlElement("optimize_type")]
        public long OptimizeType { get; set; }

        /// <summary>
        /// 该日期使用的排班服务任务ID
        /// </summary>
        [XmlElement("work_schedule_service_task_id")]
        public string WorkScheduleServiceTaskId { get; set; }

        /// <summary>
        /// 待轮班的日期（yyyyMMdd）
        /// </summary>
        [XmlElement("work_shift_date")]
        public string WorkShiftDate { get; set; }
    }
}
