using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowuptaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorFollowuptaskCreateModel : AopObject
    {
        /// <summary>
        /// 智能体ID,可不传入
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_list")]
        [XmlArrayItem("follow_up_create_task_biz_id_request")]
        public List<FollowUpCreateTaskBizIdRequest> BizList { get; set; }

        /// <summary>
        /// AI随访任务过期时间
        /// </summary>
        [XmlElement("dead_line")]
        public string DeadLine { get; set; }

        /// <summary>
        /// 服务商维护的医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 服务商维护的医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// AI随访模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
