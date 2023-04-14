using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginuseconfigCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappPluginuseconfigCancelModel : AopObject
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序应用 ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件研发版本
        /// </summary>
        [XmlElement("plugin_dev_version")]
        public string PluginDevVersion { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }
    }
}
