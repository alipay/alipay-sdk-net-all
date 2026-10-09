using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinTaskCreateResponse.
    /// </summary>
    public class DatadigitalAicsDevinTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务code
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务规则code
        /// </summary>
        [XmlElement("task_rules_code")]
        public string TaskRulesCode { get; set; }
    }
}
