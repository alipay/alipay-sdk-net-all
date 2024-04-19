using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppStressHeartbeatUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppStressHeartbeatUploadModel : AopObject
    {
        /// <summary>
        /// 引擎错误原因
        /// </summary>
        [XmlElement("exception")]
        public string Exception { get; set; }

        /// <summary>
        /// 压测实例的唯一标识
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 机器状态
        /// </summary>
        [XmlElement("machine_status")]
        public string MachineStatus { get; set; }

        /// <summary>
        /// json 格式的上报信息详情列表
        /// </summary>
        [XmlArray("report_detail")]
        [XmlArrayItem("stress_request_item")]
        public List<StressRequestItem> ReportDetail { get; set; }

        /// <summary>
        /// 上报时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 压测任务的唯一标识
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 请求页面的总时间，单位是 ms
        /// </summary>
        [XmlElement("total_time")]
        public string TotalTime { get; set; }
    }
}
