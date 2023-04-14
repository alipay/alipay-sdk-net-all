using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPluginuseconfigUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPluginuseconfigUpgradeModel : AopObject
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
        /// 插件appid
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 灰度策略值。枚举支持：p10、p30、p50。其中 p10 代表 10% 的用户，p30 代表 30% 的用户，p50 代表 50% 的用户。
        /// </summary>
        [XmlElement("strategy_value")]
        public string StrategyValue { get; set; }
    }
}
