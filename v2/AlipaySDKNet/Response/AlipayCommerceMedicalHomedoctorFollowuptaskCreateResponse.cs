using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowuptaskCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorFollowuptaskCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("task_create_response")]
        public List<TaskCreateResponse> TaskList { get; set; }
    }
}
