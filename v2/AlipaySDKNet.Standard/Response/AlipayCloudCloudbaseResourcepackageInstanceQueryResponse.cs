using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageInstanceQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 资源包实例详情列表
        /// </summary>
        [XmlArray("instances")]
        [XmlArrayItem("resource_package_instance")]
        public List<ResourcePackageInstance> Instances { get; set; }
    }
}
