using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionSiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionSiteInfo : AopObject
    {
        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 站点类型
        /// </summary>
        [XmlElement("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [XmlElement("site_url")]
        public string SiteUrl { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }
    }
}
