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
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
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
    }
}
