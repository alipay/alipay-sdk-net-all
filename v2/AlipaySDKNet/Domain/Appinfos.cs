using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Appinfos Data Structure.
    /// </summary>
    [Serializable]
    public class Appinfos : AopObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [XmlElement("app_type")]
        public long AppType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public long MiniAppId { get; set; }
    }
}
