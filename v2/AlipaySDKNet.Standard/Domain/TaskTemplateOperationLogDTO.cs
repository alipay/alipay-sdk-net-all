using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskTemplateOperationLogDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaskTemplateOperationLogDTO : AopObject
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 操作行为 CREATE 创建 MODIFY  修改 PUBLISH 发布 SUSPEND 暂停 RESUME  继续 STOP 终止
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 操作者uid
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
