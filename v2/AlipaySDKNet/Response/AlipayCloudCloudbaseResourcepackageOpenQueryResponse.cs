using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageOpenQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 资源包列表信息
        /// </summary>
        [XmlArray("resource_packages")]
        [XmlArrayItem("resource_package_info")]
        public List<ResourcePackageInfo> ResourcePackages { get; set; }
    }
}
