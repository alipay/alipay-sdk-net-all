using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourcestatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvResourcestatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 资源状态列表
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("resource_status")]
        public List<ResourceStatus> Resources { get; set; }
    }
}
