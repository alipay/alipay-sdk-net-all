using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageAlterQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageAlterQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前实例规格编码
        /// </summary>
        [XmlElement("current_spec_code")]
        public string CurrentSpecCode { get; set; }

        /// <summary>
        /// 资源包列表
        /// </summary>
        [XmlArray("resource_pkgs")]
        [XmlArrayItem("resource_package_info")]
        public List<ResourcePackageInfo> ResourcePkgs { get; set; }
    }
}
