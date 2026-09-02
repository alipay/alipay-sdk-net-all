using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskCreateResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TaskCreateResponse : AopObject
    {
        /// <summary>
        /// 蚂蚁健康 Open ID
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
