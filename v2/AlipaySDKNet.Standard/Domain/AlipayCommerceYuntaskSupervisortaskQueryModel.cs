using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskSupervisortaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskSupervisortaskQueryModel : AopObject
    {
        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("supervisor_id")]
        public string SupervisorId { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务模版ID
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
