using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAssistantServiceconfQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAssistantServiceconfQueryResponse : AopResponse
    {
        /// <summary>
        /// 配置服务列表
        /// </summary>
        [XmlArray("service_configs")]
        [XmlArrayItem("service_config")]
        public List<ServiceConfig> ServiceConfigs { get; set; }
    }
}
