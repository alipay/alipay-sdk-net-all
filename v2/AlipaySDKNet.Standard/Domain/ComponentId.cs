using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComponentId Data Structure.
    /// </summary>
    [Serializable]
    public class ComponentId : AopObject
    {
        /// <summary>
        /// 接入系统信息，包括system_type和source_id
        /// </summary>
        [XmlElement("business_id")]
        public BusinessId BusinessId { get; set; }

        /// <summary>
        /// 接入任务中心时，填写的source_id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// system_type
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
