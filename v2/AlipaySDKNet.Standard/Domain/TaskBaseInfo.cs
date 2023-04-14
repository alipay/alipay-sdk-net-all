using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskBaseInfo : AopObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 报名起始时间
        /// </summary>
        [XmlElement("sign_up_begin_time")]
        public string SignUpBeginTime { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [XmlElement("sign_up_end_time")]
        public string SignUpEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
