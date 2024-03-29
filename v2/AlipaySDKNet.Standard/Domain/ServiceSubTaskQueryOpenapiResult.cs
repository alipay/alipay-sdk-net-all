using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceSubTaskQueryOpenapiResult Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSubTaskQueryOpenapiResult : AopObject
    {
        /// <summary>
        /// 子任务结束时间，处理完成或处理失败前为空（yyyy-MM-dd HH24:mi:ss）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 子任务结果码，发生异常时非空
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 子任务结果信息，发生异常时非空
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 子任务开始时间，开始处理之前为空（yyyy-MM-dd HH24:mi:ss）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [XmlElement("sub_task_id")]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 子任务状态（INIT-初始，PROCESSING-处理中，SUCCESS-成功，FAILED-失败）
        /// </summary>
        [XmlElement("sub_task_status")]
        public string SubTaskStatus { get; set; }

        /// <summary>
        /// 子任务类型
        /// </summary>
        [XmlElement("sub_task_type")]
        public string SubTaskType { get; set; }
    }
}
