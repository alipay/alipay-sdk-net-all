using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PluginUseRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PluginUseRelationInfo : AopObject
    {
        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 订购时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 插件失效时间
        /// </summary>
        [XmlElement("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件构建版本
        /// </summary>
        [XmlElement("plugin_deploy_version")]
        public string PluginDeployVersion { get; set; }

        /// <summary>
        /// 插件ID
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件状态，取值包括EXECUTING/WAIT_WORKING/WORKING/STOP_WORKING/WAIT_BUY
        /// </summary>
        [XmlElement("plugin_status")]
        public string PluginStatus { get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        [XmlElement("plugin_version")]
        public string PluginVersion { get; set; }

        /// <summary>
        /// 插件运行状态，取值包括ONLINE/TRIAL/REVIEW/DEBUG
        /// </summary>
        [XmlElement("run_mode_type")]
        public string RunModeType { get; set; }

        /// <summary>
        /// 渠道来源，取值包括SHOP_MINI/PLUGIN_DEBUG/PLUGIN_TRIAL/PLUGIN_AUDIT/GENERAL_SHOP_ID
        /// </summary>
        [XmlElement("source_from")]
        public string SourceFrom { get; set; }
    }
}
