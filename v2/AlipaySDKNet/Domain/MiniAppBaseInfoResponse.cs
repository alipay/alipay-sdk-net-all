using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppBaseInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppBaseInfoResponse : AopObject
    {
        /// <summary>
        /// 小程序描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 小程序logo
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序归属者ID
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
