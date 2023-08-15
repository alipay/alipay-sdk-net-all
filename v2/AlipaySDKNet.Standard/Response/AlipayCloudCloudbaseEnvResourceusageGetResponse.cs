using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourceusageGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvResourceusageGetResponse : AopResponse
    {
        /// <summary>
        /// 资源包用量列表
        /// </summary>
        [XmlArray("workspace_resource_usages")]
        [XmlArrayItem("workspace_resource_usage")]
        public List<WorkspaceResourceUsage> WorkspaceResourceUsages { get; set; }
    }
}
