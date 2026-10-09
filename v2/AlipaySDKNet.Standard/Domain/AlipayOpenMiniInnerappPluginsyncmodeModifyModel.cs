using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginsyncmodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappPluginsyncmodeModifyModel : AopObject
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用 ID，
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 模式，SYNC/NONE
        /// </summary>
        [XmlElement("sync_mode")]
        public string SyncMode { get; set; }
    }
}
