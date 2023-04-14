using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateConfigSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateConfigSyncModel : AopObject
    {
        /// <summary>
        /// 自定义规则，字符串的形式。国际要同步到主站的拓展信息
        /// </summary>
        [XmlElement("task_context")]
        public string TaskContext { get; set; }

        /// <summary>
        /// 调度任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 配置信息的调度类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
