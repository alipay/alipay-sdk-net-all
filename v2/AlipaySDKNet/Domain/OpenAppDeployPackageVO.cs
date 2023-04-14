using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAppDeployPackageVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAppDeployPackageVO : AopObject
    {
        /// <summary>
        /// 发布标识
        /// </summary>
        [XmlElement("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 普通小程序包地址
        /// </summary>
        [XmlElement("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件包地址
        /// </summary>
        [XmlElement("plugin_url")]
        public string PluginUrl { get; set; }
    }
}
