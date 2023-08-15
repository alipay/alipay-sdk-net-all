using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourcepackageQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvResourcepackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 资源包列表
        /// </summary>
        [XmlArray("resource_packages")]
        [XmlArrayItem("resource_package")]
        public List<ResourcePackage> ResourcePackages { get; set; }
    }
}
