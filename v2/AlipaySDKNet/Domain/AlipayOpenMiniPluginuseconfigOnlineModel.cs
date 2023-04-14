using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPluginuseconfigOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPluginuseconfigOnlineModel : AopObject
    {
        /// <summary>
        /// 端参数，枚举列举：支付宝：com.alipay.alipaywallet，高德：com.amap.app
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

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
