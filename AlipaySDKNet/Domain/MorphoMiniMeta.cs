using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoMiniMeta Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoMiniMeta : AopObject
    {
        /// <summary>
        /// 小程序的名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 最新构建版本
        /// </summary>
        [XmlElement("builded_version")]
        public string BuildedVersion { get; set; }

        /// <summary>
        /// 小程序LOGO
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 当前线上版本
        /// </summary>
        [XmlElement("online_version")]
        public string OnlineVersion { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
