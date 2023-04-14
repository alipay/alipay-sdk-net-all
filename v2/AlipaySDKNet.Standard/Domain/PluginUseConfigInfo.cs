using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PluginUseConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PluginUseConfigInfo : AopObject
    {
        /// <summary>
        /// 端
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 灰度策略
        /// </summary>
        [XmlElement("gray_code")]
        public string GrayCode { get; set; }

        /// <summary>
        /// 插件研发版本
        /// </summary>
        [XmlElement("plugin_develop_version")]
        public string PluginDevelopVersion { get; set; }

        /// <summary>
        /// GRAY(灰度中)/RELEASE(在线状态)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
