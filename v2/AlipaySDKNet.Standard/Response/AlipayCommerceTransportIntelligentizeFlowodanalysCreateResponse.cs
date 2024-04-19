using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeFlowodanalysCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeFlowodanalysCreateResponse : AopResponse
    {
        /// <summary>
        /// 服务任务ID
        /// </summary>
        [XmlElement("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务类型
        /// </summary>
        [XmlElement("service_task_type")]
        public string ServiceTaskType { get; set; }

        /// <summary>
        /// 服务子任务创建结果列表
        /// </summary>
        [XmlArray("sub_task_create_result_list")]
        [XmlArrayItem("service_sub_task_create_openapi_result")]
        public List<ServiceSubTaskCreateOpenapiResult> SubTaskCreateResultList { get; set; }
    }
}
