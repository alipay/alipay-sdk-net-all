using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionPreviewUploadResponse : AopResponse
    {
        /// <summary>
        /// 构建好的包地址
        /// </summary>
        [XmlElement("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 部署版本号，一个应用、租户、端在应用中心唯一的一条发布记录版本号、
        /// </summary>
        [XmlElement("deploy_version")]
        public string DeployVersion { get; set; }
    }
}
