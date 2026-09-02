using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PluginPrivacyFields Data Structure.
    /// </summary>
    [Serializable]
    public class PluginPrivacyFields : AopObject
    {
        /// <summary>
        /// 插件所需的隐私权限
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 插件所需隐私字段名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [XmlElement("plugin_name")]
        public string PluginName { get; set; }

        /// <summary>
        /// 插件提供者的名称
        /// </summary>
        [XmlElement("plugin_provider_name")]
        public string PluginProviderName { get; set; }

        /// <summary>
        /// 让用户理解为什么需要此插件及权限
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
    }
}
