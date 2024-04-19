using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskinstanceQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskinstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务实例信息
        /// </summary>
        [XmlElement("task_instance_info")]
        public TaskInstanceInfoDTO TaskInstanceInfo { get; set; }
    }
}
