using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportWebsiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportWebsiteInfo : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("website_name")]
        public string WebsiteName { get; set; }

        /// <summary>
        /// 网站类型
        /// </summary>
        [XmlElement("website_type")]
        public string WebsiteType { get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [XmlElement("website_url")]
        public string WebsiteUrl { get; set; }
    }
}
