using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PluginBetaItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PluginBetaItemInfo : AopObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 被邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT
        /// </summary>
        [XmlElement("beta_status")]
        public string BetaStatus { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        [XmlElement("plugin_version")]
        public string PluginVersion { get; set; }

        /// <summary>
        /// 邀测二维码
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
